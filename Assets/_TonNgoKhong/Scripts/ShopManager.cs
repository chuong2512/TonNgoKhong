using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public Button btn0;
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;

    public void Geems()
    {
        btn0.interactable = false;
    }

    public void WeaponDesign()
    {
        btn1.interactable = false;
    }

    public void BonePendant()
    {
        btn2.interactable = false;
    }

    public void BoneM()
    {
        btn3.interactable = false;
    }

    public void ClothingDesign()
    {
        btn4.interactable = false;
    }

    public void ShoesDesign()
    {
        btn5.interactable = false;
    }
}