using System;
using System.Collections;
using System.Collections.Generic;
using _TonNgoKhong;
using UnityEngine;
using UnityEngine.UI;

public class PausePanel : MonoBehaviour
{
    [SerializeField] private Button _resumeBtn, _homeBtn;

    private void Start()
    {
        _resumeBtn.onClick.AddListener(ClickResume);
        _homeBtn.onClick.AddListener(ClickHome);
    }

    private void ClickHome()
    {
        SceneLoader.Instance.LoadHome();
    }

    private void ClickResume()
    {
        InGameManager.Instance.GameState = GameState.Playing;
        ScreenManager.Instance.Back();
    }
}