using System;
using Game;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class PlayerInfoTab : MonoBehaviour
    {
        [SerializeField] private Text _energyTxt;

        [SerializeField] private Text _gemTxt;

        [SerializeField] private Text _coinTxt;

        [SerializeField] private Text _levelTxt;
        [SerializeField] private Image _levelSlider;

        private PlayerData _playerData;
        
        private void Start()
        {
            _playerData = GameDataManager.Instance.playerData;
            
            SetInfo();

            OutGameAction.OnChangeCoin += InfoCoin;
            OutGameAction.OnChangeExp += InfoExp;
            OutGameAction.OnChangeGem += InfoGem;

            _energyTxt.text = "--/--";
        }

        private void OnDestroy()
        {
            OutGameAction.OnChangeCoin -= InfoCoin;
            OutGameAction.OnChangeExp -= InfoExp;
            OutGameAction.OnChangeGem -= InfoGem;
        }

        private void SetInfo()
        {
            InfoExp();
            InfoCoin();
            InfoGem();
        }

        private void InfoExp(int exp = 0)
        {
            _levelTxt.text = GameDataManager.Instance.GetLevel(out float expPercent).ToString();

            _levelSlider.fillAmount = expPercent;
        }

        private void InfoCoin(int coin = 0)
        {
            _coinTxt.text = $"{_playerData.Coin}";
        }

        private void InfoGem(int gem = 0)
        {
            _gemTxt.text = $"{_playerData.Gem}";
        }
    }
}