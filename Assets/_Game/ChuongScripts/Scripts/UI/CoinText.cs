using Game;
using TMPro;
using UnityEngine;

namespace SinhTon.Scripts.UI
{
    public class CoinText : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _tmp;

        private void OnValidate()
        {
            _tmp = GetComponentInChildren<TextMeshProUGUI>();
        }

        void Start()
        {
            OutGameAction.OnChangeCoin += OnChangeCoin;
            ShowCurrentCoin();
        }

        private void OnChangeCoin(int obj)
        {
            ShowCurrentCoin();
        }

        private void ShowCurrentCoin()
        {
            _tmp.SetText($"{GameDataManager.Instance.playerData.Coin} <sprite=0>");
        }
    }
}