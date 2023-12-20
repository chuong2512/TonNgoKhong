using System;
using DG.Tweening;
using SinhTon;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace SinhTon
{
    public class HomeScreen : AppScreen
    {
        [SerializeField] private TextMeshProUGUI _coinTMP;

        public override ScreenType GetID()
        {
            return ScreenType.HomeScreen;
        }

        protected override void Start()
        {
            base.Start();
            //SetCoinText();
            //GameManager.OnChangeCoin += OnChangeCoin;
        }

        private void OnChangeCoin(int i)
        {
            SetCoinText();
        }

        private void SetCoinText()
        {
            _coinTMP.SetText(GameDataManager.Instance.playerData.coin.ToString() + "<sprite=0>");
        }

        private void OnDestroy()
        {
            SGameManager.OnChangeBullet -= OnChangeCoin;
        }
    }
}