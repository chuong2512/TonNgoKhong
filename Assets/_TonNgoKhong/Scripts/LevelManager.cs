using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class LevelObjectUnlocked
{
    public int LevelUnlock;
    public Sprite[] image;
}

[System.Serializable]
public class itemUnlocked
{
    public string itemName;
    public int price;

    public string itemType;
}

public class LevelManager : MonoBehaviour
{
    public GameObject panelParent;
    public GameObject[] panelchilden;
    public itemUnlocked[] itemUnlockeds;
    public GameObject nocoin;
    int myButtonNumber;
    public static LevelManager Instance;
    public Slider slider;
    public GameObject[] level1;
    public GameObject[] level2;
    public GameObject[] level3;
    public GameObject[] level4;
    public GameObject[] level5;
    public GameObject[] level6;
    public GameObject[] level7;
    public GameObject[] level8;
    public GameObject[] level9;

    public Button[] evolveButton;

    public Slider slidelevel;
    public Text levelText;
    public int level;
    public int xp;

    public GameObject LevelPopUp;
    public GameObject coins;
    public Image[] imageLevel;

    // Start is called before the first frame update
    void Start()
    {
        LevelManager.Instance = this;
        if (!PlayerPrefs.HasKey("level"))
        {
            PlayerPrefs.SetInt("level", 1);
        }

        InitLevel();
    }

    public void CalculLevel(int x)
    {
        Debug.Log("CalculLevel");
        xp += x;
        level = PlayerPrefs.GetInt("level");

        if (xp >= (level * 1000))
        {
            xp -= (level * 1000);
            PlayerPrefs.SetInt("level", level + 1);
            level = PlayerPrefs.GetInt("level");
            PlayerPrefs.SetInt("xp", xp);
            InitLevel();
        }
        else
        {
            PlayerPrefs.SetInt("xp", xp);
            InitLevel();
        }
    }

    public void InitLevel()
    {
        xp = PlayerPrefs.GetInt("xp");
        level = PlayerPrefs.GetInt("level");

        levelText.text = level.ToString();

        slidelevel.maxValue = level * 1000;
        slidelevel.value = xp;

        slider.value = level * 2;

        if (level >= 1)
        {
            foreach (var ii in level1)
            {
                ii.SetActive(true);
            }
        }

        if (level >= 2)
        {
            foreach (var ii in level2)
            {
                ii.SetActive(true);
            }
        }

        if (level >= 3)
        {
            foreach (var ii in level3)
            {
                ii.SetActive(true);
            }
        }

        if (level >= 4)
        {
            foreach (var ii in level4)
            {
                ii.SetActive(true);
            }
        }

        if (level >= 5)
        {
            foreach (var ii in level5)
            {
                ii.SetActive(true);
            }
        }

        if (level >= 6)
        {
            foreach (var ii in level6)
            {
                ii.SetActive(true);
            }
        }

        if (level >= 7)
        {
            foreach (var ii in level7)
            {
                ii.SetActive(true);
            }
        }

        if (level >= 8)
        {
            foreach (var ii in level8)
            {
                ii.SetActive(true);
            }
        }

        if (level >= 9)
        {
            foreach (var ii in level2)
            {
                ii.SetActive(true);
            }
        }

        if (level >= 10)
        {
            foreach (var ii in level2)
            {
                ii.SetActive(true);
            }
        }

        CheckAvailabelButton();
    }

    void CheckAvailabelButton()
    {
        for (int ii = 0; ii < evolveButton.Length; ii++)
        {
            if (PlayerPrefs.GetInt("evolveButton" + ii) == 1)
            {
                evolveButton[ii].interactable = false;
            }
        }
    }

    public void BuyEvolve(int ii)
    {
        myButtonNumber = ii;
        int CoinsInt;
        CoinsInt = PlayerPrefs.GetInt("coins");
    }

    public void BuyItems(int ii)
    {
        int CoinsInt;
        CoinsInt = PlayerPrefs.GetInt("coins");

        if (itemUnlockeds[ii].price <= CoinsInt)
        {
            if (itemUnlockeds[ii].itemType == "Health")
            {
                AddHealth();
            }
            else
            {
                AddSpead();
            }

            CoinsInt -= itemUnlockeds[ii].price;
            PlayerPrefs.SetInt("coins", CoinsInt);
            PlayerPrefs.SetInt("evolveButton" + ii, 1);
            CheckAvailabelButton();
            panelParent.SetActive(false);
            foreach (var pp in panelchilden)
            {
                pp.SetActive(false);
            }

            /*managerMecanique = FindObjectOfType<ManagerMecanique>();
            managerMecanique.InitText();*/
        }
        else
        {
            Debug.Log("need coins");

            nocoin.SetActive(true);
        }
    }

    public void AddHealth()
    {
        float hh = PlayerPrefs.GetFloat("Health");
        PlayerPrefs.SetFloat("Health", hh + 10);
        Debug.Log("Health" + PlayerPrefs.GetFloat("Health"));
    }

    public void AddSpead()
    {
        float ss = PlayerPrefs.GetFloat("Spead");
        PlayerPrefs.SetFloat("Spead", ss + 2);
        Debug.Log("Spead" + PlayerPrefs.GetFloat("Spead"));
    }
}