using System;
using Coffee.UIEffects;
using EnhancedUI;
using EnhancedUI.EnhancedScroller;
using JetBrains.Annotations;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class EvovleCellView : ConstantSizeCellView
    {
        [FoldoutGroup("Setting")] [SerializeField]
        private Image _icon;

        [FoldoutGroup("Setting")] [SerializeField]
        private Image _slider;

        [FoldoutGroup("Setting")] [SerializeField]
        private TextMeshProUGUI _level;

        [FoldoutGroup("Setting")] [SerializeField] [CanBeNull]
        private Button _button;

        [FoldoutGroup("Setting")] [SerializeField]
        private GameObject _noti;


        [FoldoutGroup("Setting")] [SerializeField] [CanBeNull]
        private UIEffect[] _grayScale;


        public override Type Type => typeof(EvovleLevelData);

        private EvovleLevelData _data;

        private void Start()
        {
            _button.onClick.AddListener(OnClickButton);
        }

        private void OnClickButton()
        {
            switch (_data.state)
            {
                case EvolveState.Current:

                    ScreenManager.Instance.OpenScreen<EvolveLevel>(ScreenType.EvolvePopup, new EvolveLevel()
                    {
                        level = _data.level,
                        _rectTransform = _icon.GetComponent<RectTransform>()
                    });
                    break;
                case EvolveState.Unlock:
                    ToastManager.Instance.ShowMessageToast("Đã mở khoá");
                    break;
                case EvolveState.Lock:
                    ToastManager.Instance.ShowWarningToast("Mở khoá level hiện tại trước !!");
                    break;
            }
        }

        public override void SetData(ref SmallList<ScrollData> data, int dataIndex)
        {
            _data = (EvovleLevelData) data[dataIndex];


            _slider.fillAmount = 0;
            _icon.sprite = _data.icon;
            _icon.SetNativeSize();
            _noti.SetActive(false);

            switch (_data.state)
            {
                case EvolveState.Current:
                    _slider.fillAmount = 0.5f;
                    _noti.SetActive(true);
                    SetUnLock();
                    break;
                case EvolveState.Unlock:
                    _slider.fillAmount = 1;
                    SetUnLock();
                    break;
                case EvolveState.Lock:
                    SetLock();
                    break;
            }

            _level.SetText($"Lv.{_data.level + 1} - {_data.stat}");
        }

        public void SetGray(bool b)
        {
            for (int i = 0; i < _grayScale.Length; i++)
            {
                _grayScale[i].enabled = b;
            }
        }

        protected virtual void SetLock()
        {
            SetGray(true);
        }

        protected virtual void SetUnLock()
        {
            SetGray(false);
        }
    }
}