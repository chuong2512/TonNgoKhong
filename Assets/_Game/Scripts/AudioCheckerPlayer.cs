using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class AudioCheckerPlayer : MonoBehaviour
{
    private void Start()
    {
        InGameAction.OnGameStateChange += OnGameStateChange;
    }

    private void OnGameStateChange()
    {
        AudioManager(InGameManager.Instance.IsPlaying);
    }

    private void OnDestroy()
    {
        InGameAction.OnGameStateChange -= OnGameStateChange;
    }

    private void AudioManager(bool b)
    {
        MasterAudioManager.SetPlaylistVolume(b ? 1 : 0);
    }
}