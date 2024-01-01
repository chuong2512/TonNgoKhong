using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerUI : MonoBehaviour
{
    [Header("Managers")]
    public SplashManager manager;

    [Header("Component")]
    public GameObject ScreenSplash;
    public GameObject ScreenGamePlay;
    public GameObject Audio;

    [Header("Boolean Manager")]
    internal bool CheckSplash = true;
    internal bool CheckGamePlay = true;
    internal bool ActivateMusic = true;

    void Update()
    {
        if(CheckSplash == true && manager.GameLoaded == true)
        {
            ScreenSplash.SetActive(false);
            if(ActivateMusic == true)
            {
                Audio.SetActive(true);
                ActivateMusic = false;
            }
            CheckSplash = false;
        }
        if(CheckGamePlay == true)
        {
            ScreenSplash.SetActive(false);
            ScreenGamePlay.SetActive(true);
            CheckGamePlay = false;
        }
    }
}
