using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class ItemsEquipement
{
    public string name;
    public string type;
    public Text levelText;
    public Sprite image;
    public int Level;
}
public class MyEquipement : MonoBehaviour
{
    public GameObject upgradeButton;
    public ItemsEquipement [] itemsEquipement;

    public Image sheild;
    public Text sheildText;
    public int sheildselected;

    public Image gun;
    public Text gunText;
    public int gunselected;

    public Image ring;
    public Text ringText;
    public int ringselected;

    public Image ninja;
    public Text ninjaText;
    public int ninjaselected;

    public Image shoes;
    public Text shoesText;
    public int shoesselected;

    public int itemsE;
    // Start is called before the first frame update
    void Start()
    {
       // PlayerPrefs.DeleteAll();
        Init();
        upgradeButton.SetActive(false);
    }
    private void Init()
    {
        if (!PlayerPrefs.HasKey("gun"))
        {
            PlayerPrefs.SetInt("sheild", 0);
            PlayerPrefs.SetInt("ring", 3);
            PlayerPrefs.SetInt("ninja", 6);
            PlayerPrefs.SetInt("gun", 8);
            PlayerPrefs.SetInt("shoes", 10);
            //set  items level
            PlayerPrefs.SetInt("sheild1", 1);
            PlayerPrefs.SetInt("sheild2", 1);
            PlayerPrefs.SetInt("sheild3", 1);

            PlayerPrefs.SetInt("ring1", 1);
            PlayerPrefs.SetInt("ring2", 1);
            PlayerPrefs.SetInt("ring3", 1);

            PlayerPrefs.SetInt("ninja1", 1);
            PlayerPrefs.SetInt("ninja2", 1);

            PlayerPrefs.SetInt("gun1", 1);
            PlayerPrefs.SetInt("gun2", 1);

            PlayerPrefs.SetInt("shoes1", 1);
            PlayerPrefs.SetInt("shoes2", 1);
            PlayerPrefs.SetInt("shoes3", 1);



        }
        else
        {
            sheildselected = PlayerPrefs.GetInt("sheild");

            gunselected = PlayerPrefs.GetInt("gun");
            ringselected = PlayerPrefs.GetInt("ring");
            ninjaselected = PlayerPrefs.GetInt("ninja");
            shoesselected = PlayerPrefs.GetInt("shoes");

            itemsEquipement[0].Level = PlayerPrefs.GetInt("sheild1");
            itemsEquipement[1].Level = PlayerPrefs.GetInt("sheild2");
            itemsEquipement[2].Level = PlayerPrefs.GetInt("sheild3");

            itemsEquipement[3].Level = PlayerPrefs.GetInt("ring1");
            itemsEquipement[4].Level = PlayerPrefs.GetInt("ring2");
            itemsEquipement[5].Level = PlayerPrefs.GetInt("ring3");

            itemsEquipement[6].Level = PlayerPrefs.GetInt("ninja1");
            itemsEquipement[7].Level = PlayerPrefs.GetInt("ninja2");

            itemsEquipement[8].Level = PlayerPrefs.GetInt("gun1");
            itemsEquipement[9].Level = PlayerPrefs.GetInt("gun2");

            itemsEquipement[10].Level = PlayerPrefs.GetInt("shoes1");
            itemsEquipement[11].Level = PlayerPrefs.GetInt("shoes2");
            itemsEquipement[12].Level = PlayerPrefs.GetInt("shoes3");

            foreach(var obj in itemsEquipement)
            {
                obj.levelText.text = "Lv."+obj.Level.ToString();
            }
            FirstInit(sheildselected);
            FirstInit(gunselected);
            FirstInit(ringselected);
            FirstInit(ninjaselected);
            FirstInit(shoesselected);
        }

        for (int ii = 0; ii <= itemsEquipement.Length; ii++)
        {

        }
    }
   void FirstInit(int ii)
    {
        switch (ii)
        {
            case 0:
                sheild.sprite = itemsEquipement[0].image;

                break;
            case 1:
                sheild.sprite = itemsEquipement[1].image;
                break;
            case 2:
                sheild.sprite = itemsEquipement[2].image;
                break;
            case 3:
                ring.sprite = itemsEquipement[3].image;
                break;
            case 4:
                ring.sprite = itemsEquipement[4].image;
                break;
            case 5:
                ring.sprite = itemsEquipement[5].image;
                break;
            case 6:
                ninja.sprite = itemsEquipement[6].image;
                break;
            case 7:
                ninja.sprite = itemsEquipement[7].image;

                break;

            case 8:
                gun.sprite = itemsEquipement[8].image;
                break;
            case 9:
                gun.sprite = itemsEquipement[9].image;
                break;
            case 10:
                shoes.sprite = itemsEquipement[10].image;
                break;
            case 11:
                shoes.sprite = itemsEquipement[11].image;
                break;
            case 12:
                shoes.sprite = itemsEquipement[12].image;
                break;

            default:
                print("Incorrect intelligence level.");
                break;
        }
    }
    public void SelectItem(int item)
    {
        upgradeButton.SetActive(true);

        itemsE = item;
        switch (itemsE)
        {
            case 0:
                sheild.sprite = itemsEquipement[0].image;
                PlayerPrefs.SetInt("sheild", 0);
                break;
            case 1:
                sheild.sprite = itemsEquipement[1].image;
                PlayerPrefs.SetInt("sheild", 1);
                break;
            case 2:
                sheild.sprite = itemsEquipement[2].image;
                PlayerPrefs.SetInt("sheild", 2);
                break;
            case 3:
                ring.sprite = itemsEquipement[3].image;
                PlayerPrefs.SetInt("ring", 3);
                break;
            case 4:
                ring.sprite = itemsEquipement[4].image;
                PlayerPrefs.SetInt("ring", 4);
                break;
            case 5:
                ring.sprite = itemsEquipement[5].image;
                PlayerPrefs.SetInt("ring", 5);
                break;
            case 6:
                ninja.sprite = itemsEquipement[6].image;
                PlayerPrefs.SetInt("ninja", 6);

                break;
            case 7:
                ninja.sprite = itemsEquipement[7].image;
                PlayerPrefs.SetInt("ninja", 7);


                break;
           
            case 8:
                gun.sprite = itemsEquipement[8].image;
                PlayerPrefs.SetInt("gun", 8);
                break;
            case 9:
                gun.sprite = itemsEquipement[9].image;
                PlayerPrefs.SetInt("gun", 9);
                break;
            case 10:
                shoes.sprite = itemsEquipement[10].image;
                PlayerPrefs.SetInt("shoes", 10);
                break;
            case 11:
                shoes.sprite = itemsEquipement[11].image;
                PlayerPrefs.SetInt("shoes", 11);
                break;
            case 12:
                shoes.sprite = itemsEquipement[12].image;
                PlayerPrefs.SetInt("shoes", 12);
                break;
           
            default:
                print("Incorrect intelligence level.");
                break;
        }
        for (int ii = 0; ii <= itemsEquipement.Length; ii++)
        {

        }
    }
    public void Upgrade()
    {
        
        if (Application.isEditor)
        {
            CompleteMethod(true, "dsfd");
        }
        else
        {
            Advertisements.Instance.ShowRewardedVideo(CompleteMethod);
        }
    }
    private void CompleteMethod(bool completed, string advertiser)
    {
        Debug.Log("Closed rewarded from: " + advertiser + " -> Completed " + completed);
        if (completed == true)
        {
            switch (itemsE)
            {
                case 0:
                    PlayerPrefs.SetInt("sheild1", PlayerPrefs.GetInt("sheild1") + 1);
                    break;
                case 1:
                    PlayerPrefs.SetInt("sheild2", PlayerPrefs.GetInt("sheild2") + 1);
                    break;
                case 2:
                    PlayerPrefs.SetInt("sheild3", PlayerPrefs.GetInt("sheild3") + 1);
                    break;
                case 3:
                    PlayerPrefs.SetInt("ring1", PlayerPrefs.GetInt("ring1") + 1);
                    break;
                case 4:
                    PlayerPrefs.SetInt("ring2", PlayerPrefs.GetInt("ring2") + 1);
                    break;
                case 5:
                    PlayerPrefs.SetInt("ring3", PlayerPrefs.GetInt("ring3") + 1);
                    break;
                case 6:
                    PlayerPrefs.SetInt("ninja1", PlayerPrefs.GetInt("ninja1") + 1);
                    break;
                case 7:
                    PlayerPrefs.SetInt("ninja2", PlayerPrefs.GetInt("ninja2") + 1);

                    break;
             
                case 8:
                    PlayerPrefs.SetInt("gun1", PlayerPrefs.GetInt("gun1") + 1);
                    break;
                case 9:
                    PlayerPrefs.SetInt("gun2", PlayerPrefs.GetInt("gun2") + 1);
                    break;
                case 10:
                    PlayerPrefs.SetInt("shoes1", PlayerPrefs.GetInt("shoes1") + 1);
                    break;
                case 11:
                    PlayerPrefs.SetInt("shoes2", PlayerPrefs.GetInt("shoes2") + 1);
                    break;
                case 12:
                    PlayerPrefs.SetInt("shoes3", PlayerPrefs.GetInt("shoes3") + 1);
                    break;

                default:
                    print("Incorrect intelligence level.");
                    break;
            }
            Init();
        }
        else
        {

            //no reward
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
