using System;
using UnityEngine;
using UnityEngine.UI;

namespace _TonNgoKhong.Shop
{
    public class ShopCoinBtn : MonoBehaviour
    {
        [SerializeField] private int _amount, _price;
        [SerializeField] private Button _button;
        [SerializeField] private Text _amountText, _priceText;

        private PlayerData _player;

        private void Start()
        {
            _player = GameDataManager.Instance.playerData;

            _button.onClick.AddListener(OnClickButton);

            _amountText.text = $"x{_amount}";
            _priceText.text = _price.ToString();
        }

        private void OnClickButton()
        {
            if (_player.Gem >= _price)
            {
                _player.Gem -= _price;
                _player.Coin += _amount;
            }
            else
            {
                ToastManager.Instance.ShowWarningToast("Không đủ linh đan. Hãy nạp thêm.");
            }
        }
    }
}