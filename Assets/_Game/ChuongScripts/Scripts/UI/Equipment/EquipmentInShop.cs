using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class EquipmentInShop : EquipmentIcon
    {
        [SerializeField] private int ID, _price;
        [SerializeField] private Button _button;
        [SerializeField] private Text _priceText;
        [SerializeField] private Text _nameText;

        private PlayerData _player;
        private GameDataManager _dataManager => GameDataManager.Instance;

        private void Start()
        {
            _player = GameDataManager.Instance.playerData;

            _button.onClick.AddListener(OnClickButton);

            ShowInfoWithID(ID);

            var equipmentData = _dataManager.EquipmentSO.GetEquipmentData(ID);

            _nameText.text = equipmentData.name;
            _priceText.text = _price.ToString();
        }

        private void OnClickButton()
        {
            if (_player.Gem >= _price)
            {
                _player.Gem -= _price;

                GameDataManager.Instance.AddItem(ID);
                ToastManager.Instance.ShowMessageToast("Mua thành công !!!");
            }
            else
            {
                ToastManager.Instance.ShowWarningToast("Không đủ linh đan. Hãy nạp thêm.");
            }
        }
    }
}