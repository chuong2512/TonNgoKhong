using System;
using UnityEngine;

namespace TonNgoKhong.Scripts.ButtonGroup
{
    public class TabButtonGroup : MonoBehaviour
    {
        [SerializeField] private TabButton[] _buttons;

        private void OnValidate()
        {
            _buttons = GetComponentsInChildren<TabButton>();
        }

        private void Start()
        {
            for (int i = 0; i < _buttons.Length; i++)
            {
                var index = i;
                _buttons[i].SetListener(() => ChooseButton(index));
            }

            ChooseButton(2);
        }

        private void ChooseButton(int indexButton)
        {
            if ( _buttons[indexButton].IsLock)
            {
                ToastManager.Instance.ShowMessageToast("Chức năng đang khoá!");
                return;
            }
            
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