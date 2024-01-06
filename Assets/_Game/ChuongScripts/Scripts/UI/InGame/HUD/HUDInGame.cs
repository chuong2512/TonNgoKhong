using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUDInGame : MonoBehaviour
{
    [Header("UI Text Manager")] public TextMeshProUGUI TimeTMP;
    public TextMeshProUGUI ExpTMP;
    public TextMeshProUGUI KilledTMP;
    public TextMeshProUGUI CoinTMP;

    public Button pauseBtn;
    
    private void Start()
    {
        InGameAction.OnCoinChange += OnCoinChange;
        InGameAction.OnKillChange += OnKillChange;
        InGameAction.OnExpChange += OnExpChange;
        InGameAction.OnTimeChange += OnTimeChange;
        
        pauseBtn.onClick.AddListener(OnCickPauseBtn);
    }

    private void OnCickPauseBtn()
    {
        GameManager.Instance.GameState = GameState.Pause;
        ScreenManager.Instance.OpenScreen(ScreenType.Pause);
    }

    private void OnDestroy()
    {
        InGameAction.OnCoinChange -= OnCoinChange;
        InGameAction.OnKillChange -= OnKillChange;
        InGameAction.OnExpChange -= OnExpChange;
        InGameAction.OnTimeChange -= OnTimeChange;
        
        pauseBtn.onClick.RemoveAllListeners();
    }

    private void OnCoinChange()
    {
    }

    private void OnKillChange()
    {
    }

    private void OnExpChange()
    {
    }

    private void OnTimeChange()
    {
    }
}