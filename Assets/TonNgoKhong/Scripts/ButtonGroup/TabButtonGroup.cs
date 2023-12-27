using System;
using UnityEngine;

namespace TonNgoKhong.Scripts.ButtonGroup
{
    public class TabButtonGroup : MonoBehaviour
    {
        [SerializeField] private AButton[] _buttons;

        private void OnValidate()
        {
            _buttons = GetComponentsInChildren<AButton>();
        }

        private void Start()
        {
            for (int i = 0; i < _buttons.Length; i++)
            {
                var index = i;
                _buttons[i].SetListener(() => ChooseButton(index));
            }
        }

        private void ChooseButton(int indexButton)
        {
            for (int i = 0; i < _buttons.Length; i++)
            {
                if (i == indexButton)
                {
                    _buttons[i].OnChoose();
                }
                else
                {
                    _buttons[i].OnUnChoose();
                }
            }
        }
    }
}