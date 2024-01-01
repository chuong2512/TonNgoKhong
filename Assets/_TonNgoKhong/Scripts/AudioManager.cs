using System.Collections;
using System.Collections.Generic;
using SinhTon;
using UnityEngine;

[DefaultExecutionOrder(-99)]
public class AudioManager : Singleton<AudioManager>
{
    [SerializeField] private AudioClip _clickClip;
    public AudioSource musicSource;

    private AudioClip _audioClip;

    public void ClickSound()
    {
        musicSource.PlayOneShot(_clickClip);
    }

    public void Fire(AudioClip currentSong)
    {
        musicSource.PlayOneShot(currentSong);
    }

    [Header("Componenet Sounds")] 
    public GameObject Sound;
    public GameObject Music;
    public GameObject Vibration;

    private SettingData _setting;

    void Start()
    {
        _setting = GameDataManager.Instance.settingData;
    }

    void Update()
    {
        Sound.SetActive(_setting.Sound);
        Music.SetActive(_setting.Music);
        Vibration.SetActive(_setting.Vibration);
    }
}