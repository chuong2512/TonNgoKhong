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
                Debug.Log($"Set Button : {index}");
                _buttons[i].SetListener(() => ChooseButton(index));
            }

            ChooseButton(2);
        }

        private void ChooseButton(int indexButton)
        {
            Debug.Log($"Choose Button : {indexButton}");
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