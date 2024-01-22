using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class ShopGemBtn : MonoBehaviour
    {
        [SerializeField] private int _amount;
        [SerializeField] private float _price;
        [SerializeField] private Button _button;
        [SerializeField] private Text _amountText, _priceText;

        private PlayerData _player;

        private void Start()
        {
            _player = GameDataManager.Instance.playerData;

            _button.onClick.AddListener(OnClickButton);

            _amountText.text = $"x{_amount}";
            _priceText.text = $"$ {_price}";
        }

        private void OnClickButton()
        {
            _player.Gem += _amount;
        }
    }
}