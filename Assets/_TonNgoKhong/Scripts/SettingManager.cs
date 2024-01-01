using System.Collections;
using System.Collections.Generic;
using SinhTon;
using UnityEngine.UI;
using UnityEngine;

public class SettingManager : MonoBehaviour
{
    [Header("Sound")] public GameObject SActiveBtn;
    public GameObject SInactiveBtn;
    public GameObject SIconActive;
    public GameObject SIconInactive;

    [Header("Music")] public GameObject MActiveBtn;
    public GameObject MInactiveBtn;
    public GameObject MIconActive;
    public GameObject MIconInactive;

    [Header("Vibration")] public GameObject VActiveBtn;
    public GameObject VInactiveBtn;
    public GameObject VIconActive;
    public GameObject VIconInactive;

    private SettingData _setting;

    void Start()
    {
        _setting = GameDataManager.Instance.settingData;

        if (_setting.Music)
            MusicActive();
        else
            MusicInactive();

        if (_setting.Vibration)
            VibrationActive();
        else
            VibrationInactive();

        if (_setting.Sound)
            SoundActive();
        else
            SoundInActive();
    }

    public void SoundActive()
    {
        SActiveBtn.SetActive(true);
        SInactiveBtn.SetActive(false);
        SIconActive.SetActive(true);
        SIconInactive.SetActive(false);
        _setting.Sound = true;
    }

    public void SoundInActive()
    {
        SActiveBtn.SetActive(false);
        SInactiveBtn.SetActive(true);
        SIconActive.SetActive(false);
        SIconInactive.SetActive(true);
        _setting.Sound = false;
    }

    public void MusicActive()
    {
        MActiveBtn.SetActive(true);
        MInactiveBtn.SetActive(false);
        MIconActive.SetActive(true);
        MIconInactive.SetActive(false);
        _setting.Music = true;
    }

    public void MusicInactive()
    {
        MActiveBtn.SetActive(false);
        MInactiveBtn.SetActive(true);
        MIconActive.SetActive(false);
        MIconInactive.SetActive(true);
        _setting.Music = false;
    }

    public void VibrationActive()
    {
        VActiveBtn.SetActive(true);
        VInactiveBtn.SetActive(false);
        VIconActive.SetActive(true);
        VIconInactive.SetActive(false);
        _setting.Vibration = true;
    }

    public void VibrationInactive()
    {
        VActiveBtn.SetActive(false);
        VInactiveBtn.SetActive(true);
        VIconActive.SetActive(false);
        VIconInactive.SetActive(true);
        _setting.Vibration = false;
    }

    public void Click()
    {
        AudioManager.Instance.ClickSound();
    }
}