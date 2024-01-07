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
    [Header("Integer Manager")] internal int KilledValue = 0;
    internal int ExpValue = 0;
    internal int CoinValue = 0;

    private int _expLevel = 100;

    internal bool SpawnObject = true;
    internal bool RightFill = true;
    internal bool LeftFill = true;

    public float PercentLevel => (float) ExpValue / _expLevel;

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

            InGameAction.OnGameStateChange?.Invoke();
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
    }

    private void OnResumeGame()
    {
        PlayerManager.Instance.Play();
    }

    public void AddExp(int exp = 1)
    {
        ExpValue += exp;

        InGameAction.OnExpChange?.Invoke(ExpValue);

        if (ExpValue >= _expLevel)
        {
            ExpValue = 0;
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