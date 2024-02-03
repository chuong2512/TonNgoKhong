using System;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;



public class IAPController : MonoBehaviour, IStoreListener
{
    public GameObject RestoreButton;

    public GameObject PanelReward;
    
    public static IAPController instance;
    private static IStoreController m_StoreController;
    private static IExtensionProvider m_StoreExtensionProvider;

    //Step 1 create your products
    private string PackCharacters;
    private string ads;

    public GameObject PackCharactersPrice;
    public GameObject AdsPrice;

    public Button PackCharactersButton;
    public Button AdsButton;
    

    //************************** Adjust these methods **************************************
    public void InitializePurchasing()
    {
       
#if UNITY_ANDROID
        RestoreButton.SetActive(false);
        PackCharacters = "pack_characters";
        ads = "remove_ads";

#endif
#if UNITY_IOS
         PackCharacters = "pack_characters";
        ads = "remove_ads";
         RestoreButton.SetActive(true);

#endif
        if (PlayerPrefs.HasKey("pack_characters"))
        {
            PackCharactersPrice.SetActive(false);
            PackCharactersButton.interactable = false;
        }
        if (PlayerPrefs.HasKey("ads"))
        {
            AdsPrice.SetActive(false);
            AdsButton.interactable = false;
        }

       
       
        if (IsInitialized()) { return; }
        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

        //Step 2 choose if your product is a consumable or non consumable
        builder.AddProduct(PackCharacters, ProductType.NonConsumable);
        builder.AddProduct(ads, ProductType.NonConsumable);

        UnityPurchasing.Initialize(this, builder);
    }

   
    private bool IsInitialized()
    {
        return m_StoreController != null && m_StoreExtensionProvider != null;
    }


    //Step 3 Create methods

    public void BuyCharacters()
    {
        if (!PlayerPrefs.HasKey("pack_characters"))
        {
            BuyProductID(PackCharacters);
        }
        
    }
    public void BuyAds()
    {
        if (!PlayerPrefs.HasKey("ads"))
        {
            BuyProductID(ads);
        }

    }


    //Step 4 modify purchasing
    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
    {
        if (String.Equals(args.purchasedProduct.definition.id, PackCharacters, StringComparison.Ordinal))
        {
          
            PlayerPrefs.SetInt("ads", 1);
            AdsPrice.SetActive(false);
            AdsButton.interactable = false;
            PanelReward.SetActive(true);
            PlayerPrefs.SetInt("pack_characters", 1);
            PackCharactersPrice.SetActive(false);
            PackCharactersButton.interactable = false;
            Debug.Log("PackCharacters Purchased + ads");
        }
        else if(String.Equals(args.purchasedProduct.definition.id, ads, StringComparison.Ordinal))
        {
            PlayerPrefs.SetInt("ads", 1);
            AdsPrice.SetActive(false);
            AdsButton.interactable = false;
            Debug.Log("Ads Purchased");
            PanelReward.SetActive(true);
           
        }
        else
        {
            Debug.Log("Purchase Failed");
        }
        return PurchaseProcessingResult.Complete;
    }










    //**************************** Dont worry about these methods ***********************************
    private void Awake()
    {
        TestSingleton();
    }

    void Start()
    {
        if (m_StoreController == null) { InitializePurchasing(); }
    }

    private void TestSingleton()
    {
        if (instance != null) { Destroy(gameObject); return; }
        instance = this;
        //DontDestroyOnLoad(gameObject);
    }

    void BuyProductID(string productId)
    {
        if (IsInitialized())
        {
            Product product = m_StoreController.products.WithID(productId);
            if (product != null && product.availableToPurchase)
            {
                Debug.Log(string.Format("Purchasing product asychronously: '{0}'", product.definition.id));
                m_StoreController.InitiatePurchase(product);
            }
            else
            {
                Debug.Log("BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");
            }
        }
        else
        {
            Debug.Log("BuyProductID FAIL. Not initialized.");
        }
    }

    public void RestorePurchases()
    {
        if (!IsInitialized())
        {
            Debug.Log("RestorePurchases FAIL. Not initialized.");
            return;
        }

        if (Application.platform == RuntimePlatform.IPhonePlayer ||
            Application.platform == RuntimePlatform.OSXPlayer)
        {
            Debug.Log("RestorePurchases started ...");

            var apple = m_StoreExtensionProvider.GetExtension<IAppleExtensions>();
            apple.RestoreTransactions((result) => {
                Debug.Log("RestorePurchases continuing: " + result + ". If no further messages, no purchases available to restore.");
            });
        }
        else
        {
            Debug.Log("RestorePurchases FAIL. Not supported on this platform. Current = " + Application.platform);
        }
    }

    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        Debug.Log("OnInitialized: PASS");
        m_StoreController = controller;
        m_StoreExtensionProvider = extensions;
    }


    public void OnInitializeFailed(InitializationFailureReason error)
    {
        Debug.Log("OnInitializeFailed InitializationFailureReason:" + error);
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        Debug.Log(string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", product.definition.storeSpecificId, failureReason));
    }

    public void OnInitializeFailed(InitializationFailureReason error, string message)
    {
        ((IStoreListener)instance).OnInitializeFailed(error, message);
    }
}