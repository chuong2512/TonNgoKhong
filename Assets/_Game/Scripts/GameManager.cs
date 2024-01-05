using System.Collections;
using SinhTon;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.Serialization;

public class GameManager : Singleton<GameManager>
{
    [Header("Manager Controller")] public PlayerManager PlayerPerfb;
    public SpawenManager Spawner;
    public TimerManager Times;
    public ManagerWeapons WeaponSpawn;
    [FormerlySerializedAs("ManagerUI")] public InGameManager managerInGame;

    [Header("Perfabes Controller")] public GameObject UIWeapon;
    public GameObject FillingFlash;
    public GameObject ScreenAddonWap;
    public GameObject[] Enemys;

    [Header("Levels World")] public GameObject ContainerWorld;

    [Header("UI Manager")] public Image HealthBar;
    public Image ReloadWeapon;
    public Image ScoringLevel;
    public Image FillingReweapon;
    public Color[] myColors;

    [Header("UI Text Manager")] public TextMeshProUGUI ScoringValue;
    public TextMeshProUGUI ScoringValueDeux;
    public TextMeshProUGUI ValueKilled;
    public Text ValueKilledScreenFinish;
    public TextMeshProUGUI CurrentCoins;

    [Header("Float Manager")] public float SpeedEnemy;
    internal float Valeur;
    internal float ValureLevel;
    public float LerpTime = 0.1f;
    internal float t = 0;
    public float Health;
    Supplies supplies;

    [Header("Integer Manager")] internal int len;
    internal int colorIndex = 0;
    internal int CurrentKilled = 0;
    internal int CurrentCurrency = 0;
    public int CurrentReload = 0;

    [Header("Boolean Manager")] internal bool EnemyAvailable = true;
    internal bool SpawnObject = true;
    internal bool RightFill = true;
    internal bool LeftFill = true;

    internal bool NormalBolt = true;
    internal bool DiamondBolt = false;
    public bool CheckFinish = true;
    internal bool StartFlashing = false;
    public bool startmove = false;
    internal bool AvailabelWeapon = true;
    internal bool SetActiveAll = true;
    internal bool PlayerDeath = false;
    public float hh;

    void Start()
    {
        supplies = FindObjectOfType<Supplies>();

        len = myColors.Length;
        hh = PlayerPrefs.GetFloat("Health");
        Health = 100f + hh;
    }

    public float timeGenaration = 5;

    void Update()
    {
        if (SetActiveAll)
        {
            ContainerWorld.SetActive(true);
            UIWeapon.SetActive(true);
            SetActiveAll = false;
        }

        CheckEnemy();
        ReloadingWapeons();
        if (timeGenaration <= 0)
        {
            timeGenaration = 5;
            Health += supplies.restoreHP;
        }
        else
        {
            timeGenaration -= Time.deltaTime;
        }

        HealthBar.fillAmount = Health / (100f + hh + ((Health * supplies.hp) / 100));
        if (HealthBar.fillAmount == 0.5f)
        {
            HealthBar.color = Color.yellow;
        }

        if (HealthBar.fillAmount == 0.3f)
        {
            HealthBar.color = Color.red;
        }

        if (HealthBar.fillAmount == 0 && PlayerDeath == false)
        {
            Debug.Log("You are Death");
            BtnPause();
            PlayerDeath = true;
        }

        ScoringValue.text = "" + CurrentReload;
        ScoringValueDeux.text = "" + CurrentReload;
        if (CheckFinish == true)
        {
            CheckValeurFill();
            if (ScoringLevel.fillAmount == 1)
            {
                Debug.Log("ScoringLevel.fillAmount == 1");
                // WeaponSpawn.PauseFirst = Random.Range(1, 12);
                //WeaponSpawn.PauseSecond = Random.Range(1, 12);
                // WeaponSpawn.PauseThrees = Random.Range(1, 12);
                WeaponSpawn.ActivateWeapon = true;
                Times.StopTime();
                CurrentReload += 1;
                StartFlashing = true;
                ScreenAddonWap.SetActive(true);
                PlayerPerfb.GetComponent<PlayerManager>().enabled = false;
                PlayerPerfb.GetComponent<Rigidbody2D>().simulated = false;
                if (EnemyAvailable == true)
                {
                    Debug.Log("EnemyAvailable");
                    Spawner.enabled = false;
                    startmove = true;
                }

                ValureLevel = 0f;
                CheckFinish = false;
            }
        }

        if (startmove == true)
        {
            foreach (GameObject joint in Enemys)
            {
                Debug.Log("startmove");
                joint.GetComponent<EnemyManager>().enabled = false;
                joint.GetComponent<Rigidbody2D>().simulated = false;
            }
        }

        if (StartFlashing == true)
        {
            FillingReweapon.color = Color.Lerp(FillingReweapon.color, myColors[colorIndex], LerpTime * Time.deltaTime);
            t = Mathf.Lerp(t, 1f, LerpTime * Time.deltaTime);
            if (t > 0.9f)
            {
                t = 0;
                colorIndex++;
                colorIndex = (colorIndex >= len) ? 0 : colorIndex;
            }
        }

        CheckKilledAndCoins();
    }

    public void BtnPause()
    {
        AvailabelWeapon = false;
        Times.StopTime();
        PlayerPerfb.GetComponent<PlayerManager>().enabled = false;
        PlayerPerfb.GetComponent<Rigidbody2D>().simulated = false;
        if (EnemyAvailable == true)
        {
            Spawner.enabled = false;
            startmove = true;
        }
    }

    public void ResumeAfter()
    {
        startmove = false;
    }

    float shield;

    public void ResumeBtn()
    {
        AvailabelWeapon = true;
        Times.StartTime();
        hh = PlayerPrefs.GetFloat("Health");

        if (PlayerPrefs.GetInt("sheild") == 0)
        {
            shield = (PlayerPrefs.GetInt("sheild1")) * 10f;
        }
        else if (PlayerPrefs.GetInt("sheild") == 1)
        {
            shield = (PlayerPrefs.GetInt("sheild2")) * 10f;
        }
        else if (PlayerPrefs.GetInt("sheild") == 2)
        {
            shield = (PlayerPrefs.GetInt("sheild3")) * 10f;
        }

        Health = 100f + hh + shield;
        PlayerPerfb.GetComponent<PlayerManager>().enabled = true;
        PlayerPerfb.GetComponent<Rigidbody2D>().simulated = true;
        if (EnemyAvailable == true)
        {
            startmove = false;
            Enemys = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject joint in Enemys)
            {
                joint.GetComponent<EnemyManager>().enabled = true;
                joint.GetComponent<Rigidbody2D>().simulated = true;
            }
        }
    }

    void CheckKilledAndCoins()
    {
        ValueKilled.text = "" + CurrentKilled;
        ValueKilledScreenFinish.text = "" + CurrentKilled;
        CurrentCoins.text = "" + CurrentCurrency;
        PlayerPrefs.SetInt("CurrentKilled", CurrentKilled);
    }

    public void SaveDatta()
    {
        int CoinsInt;
        CoinsInt = PlayerPrefs.GetInt("coins");
        CoinsInt += CurrentCurrency;
        PlayerPrefs.SetInt("coins", CoinsInt);
    }

    void CheckValeurFill()
    {
        if (CheckFinish == true)
        {
            ScoringLevel.fillAmount = ValureLevel / (100 + CurrentReload * 30);
        }
    }

    void ReloadingWapeons()
    {
        Valeur += 1f * Time.deltaTime;
        if (ReloadWeapon.fillAmount < 1 && RightFill == true)
        {
            SpawnObject = false;
            ReloadWeapon.fillAmount = Valeur;
            LeftFill = true;
        }

        if (ReloadWeapon.fillAmount == 1 && LeftFill == true)
        {
            SpawnObject = true;
            ReloadWeapon.fillAmount = 0;
            Valeur = 0;
            LeftFill = false;
        }
    }

    void CheckEnemy()
    {
        Enemys = GameObject.FindGameObjectsWithTag("Enemy");
        Debug.Log("CheckEnemy");
        if (Enemys.Length == 0)
        {
            EnemyAvailable = false;
            NormalBolt = false;
            DiamondBolt = true;
        }
        else
        {
            EnemyAvailable = true;
            NormalBolt = true;
            DiamondBolt = false;
        }
    }

    public void FirstCont()
    {
        ScreenAddonWap.SetActive(false);
        Times.StartTime();
        PlayerPerfb.GetComponent<PlayerManager>().enabled = true;
        PlayerPerfb.GetComponent<Rigidbody2D>().simulated = true;
        if (EnemyAvailable == true)
        {
            startmove = false;
            foreach (GameObject joint in Enemys)
            {
                joint.GetComponent<EnemyManager>().enabled = true;
                joint.GetComponent<Rigidbody2D>().simulated = true;
            }
        }

        ScoringLevel.fillAmount = 0;
        StartCoroutine(CheckingFinishBtn());
    }

    public void SecondCont()
    {
        ScreenAddonWap.SetActive(false);
        Times.StartTime();
        PlayerPerfb.GetComponent<PlayerManager>().enabled = true;
        PlayerPerfb.GetComponent<Rigidbody2D>().simulated = true;
        if (EnemyAvailable == true)
        {
            startmove = false;
            foreach (GameObject joint in Enemys)
            {
                joint.GetComponent<EnemyManager>().enabled = true;
                joint.GetComponent<Rigidbody2D>().simulated = true;
            }
        }

        ScoringLevel.fillAmount = 0;
        StartCoroutine(CheckingFinishBtn());
    }

    public void ThirdCont()
    {
        ScreenAddonWap.SetActive(false);
        Times.StartTime();
        PlayerPerfb.GetComponent<PlayerManager>().enabled = true;
        PlayerPerfb.GetComponent<Rigidbody2D>().simulated = true;
        //Spawner.enabled = true;
        if (EnemyAvailable == true)
        {
            startmove = false;
            foreach (GameObject joint in Enemys)
            {
                joint.GetComponent<EnemyManager>().enabled = true;
                joint.GetComponent<Rigidbody2D>().simulated = true;
            }
        }

        ScoringLevel.fillAmount = 0;
        StartCoroutine(CheckingFinishBtn());
    }

    IEnumerator CheckingFinishBtn()
    {
        yield return new WaitForSeconds(0.5f);
        CheckFinish = true;
    }
}