using System.Collections;
using Game;
using SinhTon;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.Serialization;

public enum GameState
{
    Playing,
    Pause
}

public class GameManager : Singleton<GameManager>
{
    [Header("Manager Controller")] public PlayerManager PlayerPerfb;
    public SpawenManager Spawner;
    public TimerManager Times;

    [Header("Perfabes Controller")] public GameObject UIWeapon;
    public GameObject ScreenAddonWap;
    public GameObject[] Enemys;

    [Header("Float Manager")] public float SpeedEnemy;
    internal float Valeur;
    internal float ExpValue;
    internal float t = 0;
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
    public bool startmove = false;
    internal bool AvailabelWeapon = true;
    internal bool SetActiveAll = true;
    internal bool PlayerDeath = false;
    public float hh;

    private GameState _gameState = GameState.Playing;

    public GameState GameState
    {
        get => _gameState;
        set
        {
            if (Equals(_gameState, value))
                return;

            _gameState = value;

            switch (_gameState)
            {
                case GameState.Pause:
                    BtnPause();
                    break;
                case GameState.Playing:
                    Cont();
                    break;
            }
        }
    }

    void Start()
    {
        _gameState = GameState.Playing;

        supplies = FindObjectOfType<Supplies>();
    }

    public float timeGenaration = 5;

    void Update()
    {
        if (SetActiveAll)
        {
            UIWeapon.SetActive(true);
            SetActiveAll = false;
        }

        CheckEnemy();
        if (timeGenaration <= 0)
        {
            timeGenaration = 5;
            /*Health += supplies.restoreHP;*/
        }
        else
        {
            timeGenaration -= Time.deltaTime;
        }

        InGameAction.OnHealthChange?.Invoke();

        if (CheckFinish == true)
        {
            CheckValeurFill();
        }

        if (startmove)
        {
            foreach (GameObject joint in Enemys)
            {
                Debug.Log("startmove");
                joint.GetComponent<EnemyManager>().enabled = false;
                joint.GetComponent<Rigidbody2D>().simulated = false;
            }
        }

        /*if (StartFlashing == true)
        {
            FillingReweapon.color = Color.Lerp(FillingReweapon.color, myColors[colorIndex], LerpTime * Time.deltaTime);
            t = Mathf.Lerp(t, 1f, LerpTime * Time.deltaTime);
            if (t > 0.9f)
            {
                t = 0;
                colorIndex++;
                colorIndex = (colorIndex >= len) ? 0 : colorIndex;
            }
        }*/
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

        /*Health = 100f + hh + shield;*/
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

    public void SaveDatta()
    {
        int CoinsInt;
        CoinsInt = PlayerPrefs.GetInt("coins");
        CoinsInt += CurrentCurrency;
        PlayerPrefs.SetInt("coins", CoinsInt);
    }

    void CheckValeurFill()
    {
        float fillAmount = 0;

        if (CheckFinish == true)
        {
            fillAmount = ExpValue / (100 + CurrentReload * 30);
        }

        if (fillAmount >= 1)
        {
            Debug.Log("ScoringLevel.fillAmount == 1");

            Times.StopTime();
            CurrentReload += 1;
            ScreenAddonWap.SetActive(true);
            PlayerPerfb.GetComponent<PlayerManager>().enabled = false;
            PlayerPerfb.GetComponent<Rigidbody2D>().simulated = false;
            if (EnemyAvailable == true)
            {
                Debug.Log("EnemyAvailable");
                Spawner.enabled = false;
                startmove = true;
            }

            ExpValue = 0f;
            CheckFinish = false;

            InGameAction.OnLevelUp?.Invoke();
            ScreenManager.Instance.OpenScreen(ScreenType.AddSkill);
        }
    }

    /*void ReloadingWapeons()
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
    }*/

    void CheckEnemy()
    {
        Enemys = GameObject.FindGameObjectsWithTag("Enemy");
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

    public void Cont()
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

        StartCoroutine(CheckingFinishBtn());
    }

    IEnumerator CheckingFinishBtn()
    {
        yield return new WaitForSeconds(0.5f);
        CheckFinish = true;
    }
}