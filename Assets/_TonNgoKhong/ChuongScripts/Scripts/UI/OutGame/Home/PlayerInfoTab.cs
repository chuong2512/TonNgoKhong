using System;
using UnityEngine;
using UnityEngine.UI;

namespace _TonNgoKhong
{
    public class PlayerInfoTab : MonoBehaviour
    {
        [SerializeField] private Text _energyTxt;

        [SerializeField] private Text _gemTxt;

        [SerializeField] private Text _coinTxt;

        [SerializeField] private Text _levelTxt;
        [SerializeField] private Image _levelSlider;

        private void Start()
        {
            SetInfo();
        }

        private void SetInfo()
        {
            
        }
        
        
    }
}