using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    float _timeCounter = 0;

    public float TimeCounter => _timeCounter;

    void Update()
    {
        if (!InGameManager.Instance.IsPlaying) return;

        _timeCounter += Time.deltaTime;

        if (_timeCounter > 1)
        {
            DisplayTime(_timeCounter);
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        _timeCounter = 0;
        timeToDisplay += 1;
        InGameAction.OnTimeChange?.Invoke(timeToDisplay);
    }
}