using System;
using System.Collections;
using System.Collections.Generic;
using _TonNgoKhong;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [FoldoutGroup("Map")] [SerializeField] private Image _iconImg;
    [FoldoutGroup("Map")] [SerializeField] private Text _nameMapTxt;
    [FoldoutGroup("Map")] [SerializeField] private Text _infoMapText;
    [FoldoutGroup("Map")] [SerializeField] private Button _playBtn;

    private LevelSO _levelSo;
    private PlayerData _playerData;

    private void Start()
    {
        _levelSo = GameDataManager.Instance.LevelSo;
        _playerData = GameDataManager.Instance.playerData;

        _playBtn.onClick.AddListener(ClickPlayBtn);

        OutGameManager.OnChooseMap += OnChooseMap;

        SetInfo();
    }

    private void ClickPlayBtn()
    {
        SceneLoader.Instance.LoadMap(_playerData.choosingMap);
    }

    private void OnChooseMap(int mapIndex)
    {
        var mapItem = _levelSo.GetMapItem(mapIndex);

        var record = _playerData.GetMapWithID(mapIndex);
        var time = TimeSpan.FromSeconds(record.time);

        _nameMapTxt.text = mapItem.name;
        _infoMapText.text = $"Thời gian sống sót lâu nhất : {time.Hours}H:{time.Minutes}M:{time.Seconds}s";
    }

    private void SetInfo()
    {
        OnChooseMap(_playerData.choosingMap);
    }

    public void OpenSetting()
    {
        ScreenManager.Instance.OpenScreen(ScreenType.Setting);
    }

    public void OpenSelectMap()
    {
        ScreenManager.Instance.OpenScreen(ScreenType.SelectMap);
    }
}