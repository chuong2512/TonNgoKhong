using BabySound.Scripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SinhTon
{
    public class IAPScreen : AppPopup
    {
        [SerializeField] private BuyCoinButton[] _buttons;

        protected override void Start()
        {
            base.Start();

            for (int i = 0; i < _buttons.Length; i++)
            {
                _buttons[i].Index = i;
            }
        }

        public override void OnOpen()
        {
            
        }

        public override ScreenType GetID() => ScreenType.IAPScreen;
    }
}