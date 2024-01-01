using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
[System.Serializable]
public class MWeapons
{
    public string NamesWeapons;
    public GameObject WeaponsObject;
   
    public string DescritionWeapons;
    public int stars;
    public bool isfull;
    public Sprite spriteWeapon;
    public bool isDrone;
    public bool isSpiner;

}
[System.Serializable]

public class MSupplies
{
    public string NamesSupplies;
   

    public string DescritionSupplies;
    public int stars;
    public bool isfull;
    public Sprite spriteSupplies;
   

}
[System.Serializable]
public class MStars
{
    public GameObject[] starWS;
}
    public class ManagerWeapons : MonoBehaviour
{
    Supplies supplies;
    Sprite mysprite;
    public MWeapons[] mWeapons;
    public MSupplies[] MSupplies;
    public MStars[] mStars;
    public MStars[] mStarsSupplies;
    [Header("Controller GameObjects")]
    public GameObject DroneContainer;
    public GameObject DroneObjectsContainer;
    public GameObject SprineContainer;

    public GameObject[] starsone;
    public GameObject[] starstwo;
    public GameObject[] starstree;

   



    [Header("Managers")]
    public SpriteWeapons WeaponsManager;

    [Header("Manager Componenet Addons")]
    public GameObject GameAddonsWeapons;

    [Header("Buttons GamePlay")]
    public GameObject FirstBtn;
    public GameObject SecondBtn;
    public GameObject ThirdBtn;

    [Header("Names")]
    public Text NameOne;
    public Text NameTwo;
    public Text NameThree;

    [Header("Images")]
    public Image IconOne;
    public Image IconTwo;
    public Image IconThree;

    [Header("Description")]
    public TextMeshProUGUI DescriptionOne;
    public TextMeshProUGUI DescriptionTwo;
    public TextMeshProUGUI DescriptionThree;

    [Header("ShootYollow")]
    public Image[] YollowSprite;
    [Header("ShootGreen")]
    public Image[] GreenSprite;

 

    [Header("Int Managers")]
    public int PauseFirst;
    public int PauseSecond;
    public int PauseThrees;
    public int[] rrpause;
    [Header("WeaponSkills")]
    public int[] Weaponselected;
    [Header("SuppliesSkills")]
    public int[] suppliesselected;

    [Header("Weapon")]
    public GameObject [] weaponSkillsOBJ;
    public Image[] weaponSkillsImage;
    [Header("Supplies")]
    public GameObject[] suppliesSkillsOBJ;
    public Image[] suppliesSkillsImage;

    [Header("Boolean Manager")]
    internal bool ActivateWeapon = true;

    void Start()
    {
        supplies = FindObjectOfType<Supplies>();

        ThirdBtn.SetActive(false);
        SecondBtn.SetActive(false);
        FirstBtn.SetActive(false);
    }
    void Update()
    {
        if (ActivateWeapon == true)
        {
            if(GameManager.Instance?.ScoringLevel.fillAmount == 1)
            {
                Debug.Log("ActivateWeapon");
               
                SelectWeapon();
                ActivateWeapon = false;
            }
        }
    }
    public void SelectWeapon()
    {
        PauseOne();
        PauseTwo();
        PauseThree();




    }
    void PauseOne()
    {
        for (int ii = 0; ii <= mWeapons.Length; ii++)
        {
            PauseFirst = Random.Range(0, 12);
            if (mWeapons[PauseFirst].isfull == false)
            {
                ManagerFirstPlace();
                return;
            }
        }
        //ManagerFirstPlace();
    }
    void PauseTwo()
    {
        for (int ii = 0; ii <= mWeapons.Length; ii++)
        {
            PauseSecond = Random.Range(0, 12);
            if (mWeapons[PauseSecond].isfull == false && PauseFirst != PauseSecond)
            {

                ManagerSecondPlace();
                return;
            }
            else
            {
                PauseSecond = Random.Range(0, 12);
                if (mWeapons[PauseSecond].isfull == false && PauseFirst != PauseSecond)
                {

                    ManagerSecondPlace();
                    return;
                }
             }
        }
        // ManagerSecondPlace();
    }
    void PauseThree()
    {
        for (int ii = 0; ii <= MSupplies.Length; ii++)
        {
            PauseThrees = Random.Range(0, 6);
            if (MSupplies[PauseThrees].isfull == false)
            {
                ManagerThirdPlace();
                return;
            }
        }
        /*for (int ii = 0; ii <= mWeapons.Length; ii++)
        {
            PauseThrees = Random.Range(0, 12);
            if (mWeapons[PauseThrees].isfull == false && PauseThrees != PauseSecond && PauseThrees != PauseFirst)
            {

                Debug.Log("done");
                ManagerThirdPlace();
                return;
            }
            else
            {
                PauseThrees = Random.Range(0, 12);
                if (mWeapons[PauseThrees].isfull == false && PauseThrees != PauseSecond && PauseThrees != PauseFirst)
                {
                    ManagerThirdPlace();
                    Debug.Log("done");
                    return;
                }

            }
        }
         ManagerThirdPlace();*/
    }

    /////////
    void ManagerThirdPlace()
    {
        ThirdBtn.SetActive(true);

        Debug.Log("ManagerThirdPlace");
        NameThree.text = MSupplies[PauseThrees].NamesSupplies;
        DescriptionThree.text = MSupplies[PauseThrees].DescritionSupplies;
        IconThree.sprite = MSupplies[PauseThrees].spriteSupplies;
        foreach(var st in starstree)
        {
            st.SetActive(false);
        }
        for (int ss= 0; ss <= MSupplies[PauseThrees].stars ; ss++)
        {
            starstree[ss].SetActive(true);
        }
        ThirdBtn.GetComponent<Button>().onClick.AddListener(SelectWeaponThird);
    }
    void ManagerSecondPlace()
    {
        SecondBtn.SetActive(true);

        Debug.Log("ManagerSecondPlace");
        NameTwo.text = mWeapons[PauseSecond].NamesWeapons;
        DescriptionTwo.text = mWeapons[PauseSecond].DescritionWeapons;
        IconTwo.sprite = mWeapons[PauseSecond].spriteWeapon;
        foreach (var st in starstwo)
        {
            st.SetActive(false);
        }
        for (int ss = 0; ss <= mWeapons[PauseSecond ].stars; ss++)
        {
            starstwo[ss].SetActive(true);
        }
        SecondBtn.GetComponent<Button>().onClick.AddListener(SelectWeaponSecond);
    }
    void ManagerFirstPlace()
    {
        Debug.Log("ManagerFirstPlace");
        FirstBtn.SetActive(true);
        NameOne.text = mWeapons[PauseFirst].NamesWeapons;
        DescriptionOne.text = mWeapons[PauseFirst].DescritionWeapons;
        IconOne.sprite = mWeapons[PauseFirst].spriteWeapon;
        foreach (var st in starsone)
        {
            st.SetActive(false);
        }
        for (int ss = 0; ss <= mWeapons[PauseFirst].stars ; ss++)
        {
            starsone[ss].SetActive(true);
        }
        FirstBtn.GetComponent<Button>().onClick.AddListener(SelectWeaponFirst);

    }
    void SelectWeaponFirst()
    {
        if (mWeapons[PauseFirst].isDrone)
        {
            DroneObjectsContainer.SetActive(true);
            DroneContainer.SetActive(true);

        }
        if (mWeapons[PauseFirst].isSpiner)
        {
            
            SprineContainer.SetActive(true);
        }
        AddImages(PauseFirst);
        mWeapons[PauseFirst].WeaponsObject.SetActive(true);
        mWeapons[PauseFirst].stars++;
        if (mWeapons[PauseFirst].stars == 5)
        {
            mWeapons[PauseFirst].isfull = true;
        }
        FirstBtn.SetActive(false);

    }
    void SelectWeaponSecond()
    {
        if (mWeapons[PauseSecond].isDrone)
        {
            DroneObjectsContainer.SetActive(true);
            DroneContainer.SetActive(true);

        }
        if (mWeapons[PauseSecond].isSpiner)
        {

            SprineContainer.SetActive(true);
        }
        AddImages(PauseSecond);
        mWeapons[PauseSecond].WeaponsObject.SetActive(true);
        mWeapons[PauseSecond].stars++;
        if (mWeapons[PauseSecond].stars == 5)
        {
            mWeapons[PauseSecond].isfull = true;
        }
        SecondBtn.SetActive(false);

    }
    void SelectWeaponThird()
    {

        AddImagesSuplies(PauseThrees);
        
        MSupplies[PauseThrees].stars++;
        if (MSupplies[PauseThrees].stars == 5)
        {
            MSupplies[PauseThrees].isfull = true;
        }
        ThirdBtn.SetActive(false);

        if (PauseThrees == 0)
        {
            //GameManager 127
            supplies.hp += 20;
        }
        else if (PauseThrees == 1)
        {
            //Diamond
            supplies.Magnet += 1;
        }
        else if (PauseThrees == 2)
        {
            //BoltSHooter
            supplies.speedShoot += 10;
        }
        else if (PauseThrees == 3)
        {
            //PlayerManager
            supplies.Protect += 10;
        }
        else if (PauseThrees == 4)
        {
            supplies.restoreHP += 2;
        }
        else if (PauseThrees == 5)
        {
            //JoystickManager
            supplies.playerSpeed += 10;
        }

    }
    /// <summary>
    /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>

    public void ClearButton()
    {
        StartCoroutine(FinishingCleaning());
    }
    IEnumerator FinishingCleaning()
    {
        yield return new WaitForSeconds(1f);
        FirstBtn.GetComponent<Button>().onClick.RemoveAllListeners();
        SecondBtn.GetComponent<Button>().onClick.RemoveAllListeners();
        ThirdBtn.GetComponent<Button>().onClick.RemoveAllListeners();

     
    }
    /////////////
  

  public void  AddImages(int WP)
    {
        for ( int ii=0;ii<6 ; ii++)
        {
            if (Weaponselected[ii] == 0)
            {
                Debug.Log(Weaponselected[ii]);
                weaponSkillsOBJ[ii].SetActive(true);
                weaponSkillsImage[ii].sprite = mWeapons[WP].spriteWeapon;
                Weaponselected[ii] = WP;
                YollowSprite[ii].enabled = true;
                YollowSprite[ii].sprite = mWeapons[WP].spriteWeapon;
                break;
            }
            else if (Weaponselected[ii] == WP)
            {
                for (int ss = 0; ss <= mWeapons[WP].stars; ss++)
                {
                    mStars[ii].starWS[ss].SetActive(true);
                }
                break;
            }
        }
    }

  public void AddImagesSuplies(int WP)
    {
        for (int ii = 0; ii < 6; ii++)
        {
            if (suppliesselected[ii] == 0)
            {
                Debug.Log(suppliesselected[ii]);
                suppliesSkillsOBJ[ii].SetActive(true);
                suppliesSkillsImage[ii].sprite = MSupplies[WP].spriteSupplies;
                suppliesselected[ii] = WP;
                GreenSprite[ii].enabled = true;
                GreenSprite[ii].sprite = MSupplies[WP].spriteSupplies;
                break;
            }
            else if (suppliesselected[ii] == WP)
            {
                for (int ss = 0; ss <= MSupplies[WP].stars; ss++)
                {
                    mStarsSupplies[ii].starWS[ss].SetActive(true);
                }
                break;
            }
        }
    }
    public  void CleanImageW()
    {
        for (int ii = 0; ii < 6; ii++)
        {
            //clear weapons
                Debug.Log(Weaponselected[ii]);
                weaponSkillsOBJ[ii].SetActive(false);
                weaponSkillsImage[ii].sprite = null;
                Weaponselected[ii] = 0;
            //clear suplies

                 Debug.Log(Weaponselected[ii]);
                suppliesSkillsOBJ[ii].SetActive(false);
                suppliesSkillsImage[ii].sprite = null;
                suppliesselected[ii] = 0;


        }
    }

    public void DesactivateAll()
    {
        foreach(var ww in mWeapons)
        {
            ww.WeaponsObject.SetActive(false);
        }
        foreach (var ww in YollowSprite)
        {
            ww.enabled=false;
            ww.sprite = null;
        }
        for (int ss = 0; ss < mStars.Length; ss++)
        {
            foreach(var star in mStars[ss].starWS)
            {
                star.SetActive(false);
            }
        }
        foreach (var tt in mWeapons)
        {
            tt.stars = 0;
            tt.isfull = false;

        }
        DroneContainer.SetActive(false);
        DroneObjectsContainer.SetActive(false);
        SprineContainer.SetActive(false);
        //clear suplies
        
        foreach (var ww in GreenSprite)
        {
            ww.enabled = false;
            ww.sprite = null;
        }
        for (int ss = 0; ss < mStarsSupplies.Length; ss++)
        {
            foreach (var star in mStarsSupplies[ss].starWS)
            {
                star.SetActive(false);
            }
        }
        foreach (var tt in MSupplies)
        {
            tt.stars = 0;
            tt.isfull = false;

        }
        supplies.ResetS();
    }
}
