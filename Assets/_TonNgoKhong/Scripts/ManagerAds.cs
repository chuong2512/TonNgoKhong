using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerAds : MonoBehaviour
{
    public SelectMapManager Manager;

    public GameObject Btn;
    public GameObject M2;
    public GameObject M3;
    public GameObject M4;
    public GameObject M5;
    public GameObject M6;

    internal bool Active1 = true;
    internal bool Active2 = true;
    internal bool Active3 = true;
    internal bool Active4 = true;
    internal bool Active5 = true;

    internal bool B1 = false;
    internal bool B2 = false;
    internal bool B3 = false;
    internal bool B4 = false;
    internal bool B5 = false;

    void Check1()
    {
        Active1 = false;
        M2.SetActive(false);
        Btn.SetActive(false);
    }
    void Check2()
    {
        Active2 = false;
        M3.SetActive(false);
        Btn.SetActive(false);
    }
    void Check3()
    {
        Active3 = false;
        M4.SetActive(false);
        Btn.SetActive(false);
    }
    void Check4()
    {
        Active4 = false;
        M5.SetActive(false);
        Btn.SetActive(false);
    }
    void Check5()
    {
        Active5 = false;
        M6.SetActive(false);
        Btn.SetActive(false);
    }

}
