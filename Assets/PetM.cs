using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetM : MonoBehaviour
{
    public GameObject[] petMN;
    public int Coin;
    public int[] Price;
    public GameObject[] textOBJ;
    public int petSelected;
    public GameObject SelectButton;
    public GameObject BuyButton;

    public GameObject[] PetMenu;
    public GameObject[] SelectedImage;
    // Start is called before the first frame update
    void Start()
    {
        GameEnded();
        PlayerPrefs.SetInt("coins", 10000);
        SelectButton.SetActive(false);
        BuyButton.SetActive(false);
        petSelected = PlayerPrefs.GetInt("petSeelected");
       // PlayerPrefs.DeleteAll();
        if (!PlayerPrefs.HasKey("petSeelected"))
        {
            PlayerPrefs.SetInt("petSeelected", 0);
            PlayerPrefs.SetInt("petpurchased" + 0, 1);
        }
        foreach (var pm in PetMenu)
        {
            pm.SetActive(false);
        }

        foreach (var pm in SelectedImage)
        {
            pm.SetActive(false);
        }
        foreach (var pm in textOBJ)
        {
            pm.SetActive(true);
        }
        for (int ii=0;ii <= textOBJ.Length; ii++)
        {
            if (PlayerPrefs.GetInt("petpurchased" + ii) == 1)
            {
                textOBJ[ii].SetActive(false);

            }
        }
        SelectedImage[petSelected].SetActive(true);
        PetMenu[petSelected].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShosePet(int nn)
    {
        foreach(var pm in PetMenu)
        {
            pm.SetActive(false);
        }

        foreach (var pm in SelectedImage)
        {
            pm.SetActive(false);
        }
        petSelected = nn;
        PetMenu[petSelected].SetActive(true);
        if (PlayerPrefs.GetInt("petpurchased" + petSelected) == 1)
        {

            SelectButton.SetActive(true);
            BuyButton.SetActive(false);

        }
        else
        {
            SelectButton.SetActive(false);
            BuyButton.SetActive(true);
        }
    }

    public void SelectPet()
    {
        PlayerPrefs.SetInt("petSeelected" , petSelected);
        SelectedImage[petSelected].SetActive(true);
        SelectButton.SetActive(false);
    }

    public void BuyPet()
    {
       
            Coin = PlayerPrefs.GetInt("coins");
           
            
            if (Coin>= Price[petSelected])
        {
            Coin -= Price[petSelected];

            PlayerPrefs.SetInt("petpurchased" + petSelected, 1);
            SelectedImage[petSelected].SetActive(true);
            textOBJ[petSelected].SetActive(false);
            PlayerPrefs.SetInt("coins", Coin);
        }
        
    }

    public void GameEnded()
    {
        foreach(var mn in petMN)
        {
            mn.SetActive(false);
        }
    }

    public void StartFight()
    {
        petMN[petSelected].SetActive(true);
        petMN[petSelected].GetComponent<PetManager>().InitPet();
    }
}
