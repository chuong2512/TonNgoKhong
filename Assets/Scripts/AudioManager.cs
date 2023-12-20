using System.Collections;
using System.Collections.Generic;
using SinhTon;
using UnityEngine;

[DefaultExecutionOrder(-99)]
public class AudioManager : Singleton<AudioManager>
{
    [SerializeField] private AudioClip _clickClip;
    public AudioSource musicSource;
    public float _timePlay = 0.6f;

    private AudioClip _audioClip;
    private bool _isPlaying;
    private int _crtId = -1;

    public bool IsPlaying => _isPlaying;

    public void SetTimeCount(float time)
    {
        Play();
        SGameManager.SetTimeStop?.Invoke(time);
    }

    public void ClickSound()
    {
        musicSource.PlayOneShot(_clickClip);
    }

    private void Start()
    {
        _isPlaying = false;
        _crtId = GameDataManager.Instance.currentID;
        
        musicSource.loop = true;
    }

    public void PlaySong(int id)
    {
        GameDataManager.Instance.SetCurrentSongID(id);

        _crtId = id;
        //    _audioClip = GameDataManager.Instance.cardSo.GetBookWithID(_crtId).song;
        musicSource.clip = _audioClip;
        musicSource.Play();
        _isPlaying = true;
        SGameManager.OnPlayMusic?.Invoke(_isPlaying);
    }

    public void ClickPlayBtn()
    {
        if (!_isPlaying)
        {
            musicSource.Play();
        }
        else
        {
            musicSource.Stop();
            SGameManager.SetTimeStop.Invoke(0);
        }

        _isPlaying = !_isPlaying;

        SGameManager.OnPlayMusic?.Invoke(_isPlaying);
        Debug.Log($"PLaying : {_isPlaying}");
    }

    public void Stop()
    {
        musicSource.Stop();
        _isPlaying = false;

        SGameManager.OnPlayMusic.Invoke(_isPlaying);
    }

    public void Play()
    {
        if (!_isPlaying)
        {
            musicSource.Play();
            _isPlaying = true;
        }

        SGameManager.OnPlayMusic.Invoke(_isPlaying);
    }

    public void Fire(AudioClip currentSong)
    {
        musicSource.PlayOneShot(currentSong);
    }

    [Header("Managers")]
    public BooleanManager BoolM;

    [Header("Componenet Sounds")]
    public GameObject Sound;
    public GameObject Music;
    public GameObject Vibration;

    void Update()
    {
        if(BoolM.Sound == true)
        {
            Sound.SetActive(true);
        }
        else
        {
            Sound.SetActive(false);
        }
        if(BoolM.Music == true)
        {
            Music.SetActive(true);
        }
        else
        {
            Music.SetActive(false);
        }
        if(BoolM.Vibration == true)
        {
            Vibration.SetActive(true);
        }
        else
        {
            Vibration.SetActive(false);
        }
    }
}
