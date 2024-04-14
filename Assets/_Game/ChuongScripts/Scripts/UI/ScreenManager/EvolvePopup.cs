using System;
using Game;
using SinhTon.Scripts.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EvolvePopup : BaseScreenWithModel<EvolveLevel>
{
    [SerializeField] private RectTransform _toolTip;
    [SerializeField] private Button _upgradeBtn;
    [SerializeField] private TextMeshProUGUI _price;
    [SerializeField] private TextMeshProUGUI _level;

    private EvolveLevel _model;

    private GameDataManager _gameData => GameDataManager.Instance;

    private void Start()
    {
        _upgradeBtn.onClick.AddListener(OnClickUpgrade);
    }

    private void OnClickUpgrade()
    {
        var data = _gameData.EvolveSo.levels[_model.level];

        if (_gameData.playerData.Coin >= data.price.Value)
        {
            _gameData.playerData.Coin -= data.price.Value;
            _gameData.evolveData.Upgrade();

            ToastManager.Instance.ShowMessageToast("Nâng cấp thành công!!!");
            CloseView();
        }
        else
        {
            ToastManager.Instance.ShowWarningToast("Không đủ ngân lượng!!!");
        }
    }

    public override void BindData(EvolveLevel model)
    {
        _model = model;
        ShowData();
    }

    private void ShowData()
    {
        var data = _gameData.EvolveSo.levels[_model.level];
        _price.SetText(data.price.Value + " <sprite=0>");
        _level.SetText($"Lv.{_model.level + 1}");

        _toolTip.position = _model._rectTransform.position;
    }

    public override ScreenType GetID() => ScreenType.EvolvePopup;
}


public class EvolveLevel
{
    public RectTransform _rectTransform;
    public int level;
}