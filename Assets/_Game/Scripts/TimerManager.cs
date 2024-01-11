using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using SinhTon;
using UnityEngine;

public class TimerManager : Singleton<TimerManager>
{
    float _timeCounter = 0;
    float _timeToDisplay = 0;

    public float TimeToDisplay => _timeToDisplay;

    public TimeSpan PlayTime => TimeSpan.FromSeconds(_timeToDisplay);

    private void Start()
    {
        _timeToDisplay = 0;
    }

    void Update()
    {
        if (!InGameManager.Instance.IsPlaying) return;

        _timeCounter += Time.deltaTime;

        if (_timeCounter > 1)
        {
            DisplayTime();
        }
    }

    void DisplayTime()
    {
        _timeCounter = 0;
        _timeToDisplay += 1;
        InGameAction.OnTimeChange?.Invoke(_timeToDisplay);
    }
}