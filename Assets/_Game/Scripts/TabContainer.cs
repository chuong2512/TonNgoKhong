using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Diagnostics.Tracing;

public enum ScreenTab
{
    ScreenHome,
    ScreenShop,
    ScreenDeath,
    ScreenEquipement,
    ScreenVolve
}

public class TabContainer : MonoBehaviour
{
    public TabManager Manager;

    private void Start()
    {
        OpenScreen(ScreenTab.ScreenHome);
    }

    public void OpenScreen(ScreenTab tab)
    {
        Manager.ScreenHome.SetActive(tab == ScreenTab.ScreenHome);
        Manager.ScreenShop.SetActive(tab == ScreenTab.ScreenShop);
        Manager.ScreenEquipment.SetActive(tab == ScreenTab.ScreenEquipement);
        Manager.ScreenEvolve.SetActive(tab == ScreenTab.ScreenVolve);
    }
}