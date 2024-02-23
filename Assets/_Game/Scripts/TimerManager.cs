using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using SinhTon;
using UnityEngine;

public class TimerManager : Singleton<TimerManager>
{
    float _timeCounter = 0;
    long _timeToDisplay = 0;

    public long TimeToDisplay => _timeToDisplay;

    private DataMap _dataMap;
    
    public TimeSpan PlayTime => TimeSpan.FromSeconds(_timeToDisplay);

    private void Start()
    {
        _timeToDisplay = 0;
        
        _dataMap = GameDataManager.Instance.GetCurrentDataMap();
    }

    void Update()
    {
        if (!InGameManager.Instance.IsPlaying) return;

        _timeCounter += Time.deltaTime;

        if (_timeCounter > 1)
        {
            DisplayTime();
        }

        if (_timeToDisplay >= _dataMap.TimeToWin)
        {
            ScreenManager.Instance.OpenScreen(ScreenType.Result, new ResultModel(true));
        }
    }

    void DisplayTime()
    {
        _timeCounter = 0;
        _timeToDisplay += 1;
        InGameAction.OnTimeChange?.Invoke(_timeToDisplay);
    }
}