using System;
using System.Collections;
using System.Collections.Generic;
using _TonNgoKhong;
using Game;
using SinhTon;
using Skill;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PausePanel : AppScreen
{
    [SerializeField] private Button _resumeBtn, _homeBtn;
    [SerializeField] private Image[] _weapon, _supply;

    public TextMeshProUGUI KilledTMP;
    public TextMeshProUGUI CoinTMP;

    private void Start()
    {
        _resumeBtn.onClick.AddListener(ClickResume);
        _homeBtn.onClick.AddListener(ClickHome);
    }

    public override void OnOpen()
    {
        base.OnOpen();

        var game = InGameManager.Instance;

        CoinTMP.SetText(game.CoinValue.ToString());
        KilledTMP.SetText(game.KilledValue.ToString());

        var w = SkillSelector.Instance.GetAllCurrentWeapons();
        var s = SkillSelector.Instance.GetAllCurrentSupplies();

        var data = GameDataManager.Instance;

        for (int i = 0; i < _weapon.Length; i++)
        {
            _weapon[i].gameObject.SetActive(i < w.Count);

            if (i >= w.Count) continue;

            _weapon[i].sprite = data.SkillSo[w[i].GetHashID()].icon;
        }

        for (int i = 0; i < _supply.Length; i++)
        {
            _supply[i].gameObject.SetActive(i < s.Count);

            if (i >= s.Count) continue;

            _supply[i].sprite = data.SkillSo[s[i].GetHashID()].icon;
        }
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

    public override ScreenType GetID() => ScreenType.Pause;
}