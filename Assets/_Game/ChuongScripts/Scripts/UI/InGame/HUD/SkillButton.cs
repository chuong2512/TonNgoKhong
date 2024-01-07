using System;
using System.Collections;
using System.Collections.Generic;
using Skill;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SkillButton : MonoBehaviour
{
    [SerializeField] private Image skillIcon;
    [SerializeField] private TextMeshProUGUI tDescription;
    [SerializeField] private Text tNameSkill;
    [SerializeField] private GameObject[] stars;
    private Button _upgradeBut;
    private int _hashID = -1;

    private void Start()
    {
        _upgradeBut = GetComponent<Button>();
        _upgradeBut.onClick.AddListener(OnUpgrade);
    }

    public void Setup(int hashID)
    {
        _hashID = hashID;
        SetInfo();
    }

    private void SetInfo()
    {
        var data = GameDataManager.Instance.SkillSo[_hashID];
        skillIcon.sprite = data.icon;
        tDescription.text = data.contentSkill + " Description";
        tNameSkill.text = data.nameSkill + " name";
        var level = SkillSelector.Instance.GetSkillLevel(_hashID);
        for (int i = 0; i < level; i++)
        {
            stars[i].SetActive(true);
        }

        for (int i = level; i < stars.Length; i++)
        {
            stars[i].SetActive(false);
        }
    }

    private void OnUpgrade()
    {
        if (_hashID >= 0)
        {
            SkillSelector.Instance.UpgradeSkill(_hashID);
        }

        ClosePopUp();
    }

    private void OnDisable()
    {
        _hashID = -1;
    }

    private void ClosePopUp()
    {
        InGameManager.Instance.GameState = GameState.Playing;
        ScreenManager.Instance.Back();
    }
}