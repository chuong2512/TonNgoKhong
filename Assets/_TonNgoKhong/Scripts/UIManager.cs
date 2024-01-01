using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    ManagerWeapons managerWeapons;
    public TimerManager timer;
    public LevelsManager Level;
    public SpriteWeapons Weapons;

    [Header("Componenet Player")] public GameObject Player;
    public GameObject HelthUI;
    public GameObject LevelLocalisation;
    public GameObject CurrentLevel;

    [Header("UI Manager")] public GameObject ScreenPause;
    public GameObject ScreenGamePlay;
    public GameObject EffectFadeGamePlay;
    public GameObject FinishScreen;

    [Header("Weapons Manager")] public GameObject SpinerContainer;
    public GameObject GunW;
    public GameObject SpinnerAW;
    public GameObject SpinnerBW;


    [Header("Sprites Guns")] public Sprite Sahem;
    public Sprite Gun;
    public Sprite SpinerA;
    public Sprite SpinerB;
    public Sprite Ball;
    public Sprite Rocket;
    public Sprite DroneA;
    public Sprite DroneB;
    public Sprite DroneC;
    public Sprite FireGlass;
    public Sprite Brick;
    public Sprite FireGase;

    [Header("Strings Manager")] internal string CheckEvolve;
    internal string Checking;
    public string CurrentName;

    [Header("Boolaen Manager")] internal bool FinishScreenB = false;
    internal bool DestroyEnemys = false;
    private bool StopAllAudios = false;

    internal bool MapReady = false;

    AudioCheckerPlayer audioCheckerPlayer;

    void Start()
    {
        Checking = PlayerPrefs.GetString("CheckEvolve");
        
        PlayBtn();
    }

    void Update()
    {
        CheckEvolve = PlayerPrefs.GetString("CheckEvolve");

        if (GameManager.Instance.PlayerDeath == true && FinishScreenB == false)
        {
            DestroyEnemys = true;
            StopAllAudios = true;
            FinishScreen.SetActive(true);
            timer.StopTime();
            if (PlayerPrefs.GetInt("ads") != 1)
            {
                Advertisements.Instance.ShowInterstitial();
            }

            GameManager.Instance.PlayerDeath = false;
            GameManager.Instance.Health = 100;
            GameManager.Instance.HealthBar.color = Color.green;
            FinishScreenB = true;
        }
        else
        {
            StopAllAudios = false;
        }

        CurrentLevel = GameObject.Find(CurrentName);
    }

    public void BackBtn()
    {
        managerWeapons = FindObjectOfType<ManagerWeapons>();
        MapReady = false;
        EffectFadeGamePlay.SetActive(true);
        DestroyEnemys = true;
        managerWeapons.DesactivateAll();
        managerWeapons.CleanImageW();
        Destroy(CurrentLevel);
        StartCoroutine(StartBacking());
    }

    public void BackFinish()
    {
        managerWeapons = FindObjectOfType<ManagerWeapons>();
        MapReady = false;
        DestroyEnemys = true;
        EffectFadeGamePlay.SetActive(true);
        FinishScreen.SetActive(false);
        managerWeapons.DesactivateAll();
        managerWeapons.CleanImageW();
        Destroy(CurrentLevel);
        StartCoroutine(StartBacking());
        Advertisements.Instance.ShowInterstitial();
    }

    IEnumerator StartBacking()
    {
        yield return new WaitForSeconds(0.8f);
        Player.gameObject.GetComponent<Rigidbody2D>().simulated = true;
        DestroyEnemys = false;
        GameManager.Instance.CurrentReload = 0;
        GameManager.Instance.CurrentCurrency = 0;
        GameManager.Instance.CurrentKilled = 0;
        timer.timeRemaining = 0;
        FinishScreenB = false;
        EffectFadeGamePlay.SetActive(false);


        Player.transform.position = new Vector3(0, 0, 0);
        HelthUI.SetActive(false);
        ScreenPause.SetActive(false);
        ScreenGamePlay.SetActive(false);
    }

    public void PlayBtn()
    {
        (Instantiate(Level.Level1, Level.Level1.transform.position, Level.Level1.transform.rotation) as GameObject)
            .transform.SetParent(LevelLocalisation.transform);
        CurrentName = Level.Level1.gameObject.name + "(Clone)";
        StartCoroutine(GameStart());
    }

    IEnumerator GameStart()
    {
        yield return new WaitForSeconds(0.7f);
        if (Checking == "")
        {
            Checking = "work";
        }

        if (CheckEvolve == "")
        {
            PlayerPrefs.SetString("CheckEvolve", Checking);
        }

        Debug.Log("GameStart");

        MapReady = true;
        Player.GetComponent<PlayerManager>().enabled = true;
        GameManager.Instance.AvailabelWeapon = true;
        ScreenGamePlay.SetActive(true);
        HelthUI.SetActive(true);
        timer.StartTime();
        if (GameManager.Instance?.EnemyAvailable == true)
        {
            GameManager.Instance.startmove = false;
            foreach (GameObject joint in GameManager.Instance.Enemys)
            {
                joint.GetComponent<EnemyManager>().enabled = true;
                joint.GetComponent<Rigidbody2D>().simulated = true;
            }
        }
    }

    public void Pause()
    {
        ScreenPause.SetActive(true);
        GameManager.Instance?.BtnPause();
    }

    public void Resume()
    {
        ScreenPause.SetActive(false);
        GameManager.Instance?.ResumeBtn();
    }

    bool myaudio = true;

    public void ChangeAudio()
    {
        audioCheckerPlayer = FindObjectOfType<AudioCheckerPlayer>();
        if (myaudio == true)
        {
            myaudio = false;
            audioCheckerPlayer.AudioManager(false);
        }
        else
        {
            myaudio = true;
            audioCheckerPlayer.AudioManager(true);
        }
    }
}