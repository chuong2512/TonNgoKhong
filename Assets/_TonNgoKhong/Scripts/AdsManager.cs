using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdsManager : MonoBehaviour
{
    public static AdsManager Ads;
    ManagerMecanique managerMecanique;
    private void Start()
    {
        managerMecanique = FindObjectOfType<ManagerMecanique>();

    }
    public void Showintertitial()
    {
        if (PlayerPrefs.GetInt("ads")!=1)
        {
            Advertisements.Instance.ShowInterstitial();

        }
    }
    public void GetGems()
    {
#if UNITY_EDITOR
        int GemsInt;
        GemsInt = PlayerPrefs.GetInt("gems");
        GemsInt += 10;
        PlayerPrefs.SetInt("gems", GemsInt);
        managerMecanique.InitText();

#else
        Advertisements.Instance.ShowRewardedVideo(CompleteMethodGems);

#endif
    }
    private void CompleteMethodGems(bool completed, string advertiser)
    {
        Debug.Log("Closed rewarded from: " + advertiser + " -> Completed " + completed);
        if (completed == true)
        {
            int GemsInt;
            GemsInt = PlayerPrefs.GetInt("gems");
            GemsInt += 10;
            PlayerPrefs.SetInt("gems", GemsInt);
            managerMecanique.InitText();

        }
        else
        {
            //no reward
        }
    }
    public void GetCoin()
    {
#if UNITY_EDITOR

        int CoinsInt;
        CoinsInt = PlayerPrefs.GetInt("coins");
        CoinsInt += 30;
        PlayerPrefs.SetInt("coins", CoinsInt);
        managerMecanique.InitText();

#else
        Advertisements.Instance.ShowRewardedVideo(CompleteMethodCoins);

#endif
    }
    private void CompleteMethodCoins(bool completed, string advertiser)
    {
        Debug.Log("Closed rewarded from: " + advertiser + " -> Completed " + completed);
        if (completed == true)
        {
            int CoinsInt;
            CoinsInt = PlayerPrefs.GetInt("coins");
            CoinsInt +=30;
            PlayerPrefs.SetInt("coins", CoinsInt);
            managerMecanique.InitText();

        }
        else
        {
            //no reward
        }
    }
    public void GetPower()
    {
#if UNITY_EDITOR

        int CoinsInt;
        CoinsInt = PlayerPrefs.GetInt("flash");
        CoinsInt += 10;
        PlayerPrefs.SetInt("flash", CoinsInt);
        managerMecanique.InitText();

#else
        Advertisements.Instance.ShowRewardedVideo(CompleteMethodPower);

#endif

    }
    private void CompleteMethodPower(bool completed, string advertiser)
    {
        Debug.Log("Closed rewarded from: " + advertiser + " -> Completed " + completed);
        if (completed == true)
        {
            int CoinsInt;
            CoinsInt = PlayerPrefs.GetInt("flash");
            CoinsInt += 10;
            PlayerPrefs.SetInt("flash", CoinsInt);
            managerMecanique.InitText();

        }
        else
        {
            //no reward
        }
    }
    public void ShowrewardVideo()
    {
        Advertisements.Instance.ShowRewardedVideo(CompleteMethod);
        void CompleteMethod(bool completed, string advertiser)
        {
            Debug.Log("Closed rewarded from: " + advertiser + " -> Completed " + completed);
            if (completed == true)
            {
                //give the reward
            }
            else
            {
                //no reward
            }
        }
    }
}
