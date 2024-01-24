using Game;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class SelectMapManager : MonoBehaviour
{
    [SerializeField] private Text _chooseTxt;
    [SerializeField] private Text _nameMapTxt;
    [SerializeField] private Text _infoMapText;
    [SerializeField] private InfoMapItem[] _infoMapItems;
    [SerializeField] private Button _chooseBtn;
    [SerializeField] private HorizontalScrollSnap _horizontalScroll;

    private int _mapIndex;
    private LevelSO _levelSo;
    private PlayerData _playerData;

    private void Start()
    {
        _levelSo = GameDataManager.Instance.LevelSo;
        _playerData = GameDataManager.Instance.playerData;

        _chooseBtn.onClick.AddListener(OnChooseBtn);

        SetInfoMaps();

        _horizontalScroll.ChangePage(0);
    }

    public void OnOpen()
    {
        if (_playerData)
        {
            _horizontalScroll.ChangePage(0);
        }
    }

    private void OnChooseBtn()
    {
        if (_playerData.IsUnlockMap(_mapIndex))
        {
            _playerData.choosingMap = _mapIndex;
            _chooseTxt.text = "Đã chọn";
            OutGameAction.OnChooseMap.Invoke(_mapIndex);
        }
        else
        {
            ToastManager.Instance.ShowMessageToast("Bản đồ này đang khoá.");
        }
    }

    private void SetInfoMaps()
    {
        for (int i = 0; i < _infoMapItems.Length; i++)
        {
            _infoMapItems[i].SetInfo(_levelSo.GetMapItem(i).icon, !_playerData.IsUnlockMap(i));
        }
    }

    public void OnChooseMap(int index)
    {
        _mapIndex = index;

        var mapItem = _levelSo.GetMapItem(_mapIndex);

        _nameMapTxt.text = mapItem.name;
        _infoMapText.text = mapItem.info;
        _chooseTxt.text = IsChoosingMap(_mapIndex) ? "Đã chọn" : "Chọn";
    }

    public bool IsChoosingMap(int index)
    {
        return _playerData.choosingMap == index;
    }
}