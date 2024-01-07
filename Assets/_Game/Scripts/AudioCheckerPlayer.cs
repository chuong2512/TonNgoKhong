using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class AudioCheckerPlayer : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();

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

    public void AudioManager(bool b)
    {
        if (b)
        {
            _audioSource.Play();
        }
        else
        {
            _audioSource.Stop();
        }
    }
}