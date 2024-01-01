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

public class ManagerFloatingBtn : MonoBehaviour
{
    public GameManager Manager;

    public void OpenScreen(ScreenTab tab)
    {
        Manager.ScreenHome.SetActive(tab == ScreenTab.ScreenHome);
        Manager.ScreenShop.SetActive(tab == ScreenTab.ScreenShop);
        Manager.ScreenEquipement.SetActive(tab == ScreenTab.ScreenEquipement);
        Manager.ScreenDeath.SetActive(tab == ScreenTab.ScreenDeath);
        Manager.ScreenVolve.SetActive(tab == ScreenTab.ScreenVolve);
    }
}