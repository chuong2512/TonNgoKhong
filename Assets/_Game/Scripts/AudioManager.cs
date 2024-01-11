using System.Collections;
using System.Collections.Generic;
using Game;
using SinhTon;
using UnityEngine;

[DefaultExecutionOrder(-99)]
public class AudioManager : Singleton<AudioManager>
{
    [SerializeField] private AudioClip _clickClip;
    public AudioSource musicSource;

    private AudioClip _audioClip;

    private SettingData _setting;

    void Start()
    {
        _setting = GameDataManager.Instance.settingData;

        MasterAudioManager.SetSFXVolume(_setting.Sound ? 1 : 0);
        MasterAudioManager.SetPlaylistVolume(_setting.Music ? 1 : 0);

        GameAction.OnSFXChange += OnSfxChange;
        GameAction.OnSoundChange += OnSoundChange;
    }

    private void OnSoundChange(bool obj)
    {
        MasterAudioManager.SetSFXVolume(_setting.Sound ? 1 : 0);
    }

    private void OnSfxChange(bool obj)
    {
        MasterAudioManager.SetPlaylistVolume(_setting.Music ? 1 : 0);
    }
}