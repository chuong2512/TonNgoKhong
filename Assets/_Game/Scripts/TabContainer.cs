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

    public void OpenScreen(ScreenTab tab)
    {
        Manager.ScreenHome.SetActive(tab == ScreenTab.ScreenHome);
        Manager.ScreenShop.SetActive(tab == ScreenTab.ScreenShop);
    }
}