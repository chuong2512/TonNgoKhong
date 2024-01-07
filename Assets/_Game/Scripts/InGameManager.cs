using System.Collections;
using Game;
using SinhTon;
using UnityEngine;

public enum GameState
{
    Playing,
    Pause
}

public class InGameManager : Singleton<InGameManager>
{
    public SpawenManager Spawner;

    public GameObject[] Enemys;

    [Header("Float Manager")] public float SpeedEnemy;

    [Header("Integer Manager")] internal int KilledValue = 0;
    internal int ExpValue = 0;
    internal int CoinValue = 0;

    internal int _expLevel = 100;

    internal bool SpawnObject = true;
    internal bool RightFill = true;
    internal bool LeftFill = true;

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
                    OnPauseGame();
                    break;
                case GameState.Playing:
                    OnResumeGame();
                    break;
            }
        }
    }

    public bool IsPlaying => GameState == GameState.Playing;
    public bool IsPause => GameState == GameState.Pause;

    void Start()
    {
        _gameState = GameState.Playing;
    }

    private void OnPauseGame()
    {
        PlayerManager.Instance.Stop();
        Spawner.enabled = false;
    }

    private void OnResumeGame()
    {
        PlayerManager.Instance.Play();
        Spawner.enabled = true;
    }

    public void AddExp(int exp = 1)
    {
        ExpValue += exp;

        InGameAction.OnExpChange?.Invoke(KilledValue);

        if (ExpValue >= _expLevel)
        {
            GameState = GameState.Pause;
            InGameAction.OnLevelUp?.Invoke();
            ScreenManager.Instance.OpenScreen(ScreenType.AddSkill);
        }
    }

    public void AddKilled(int amount = 1)
    {
        KilledValue++;
        InGameAction.OnKillChange?.Invoke(KilledValue);
    }

    public void AddCoin(int amount = 1)
    {
        CoinValue++;
        InGameAction.OnCoinChange?.Invoke(CoinValue);
    }
}