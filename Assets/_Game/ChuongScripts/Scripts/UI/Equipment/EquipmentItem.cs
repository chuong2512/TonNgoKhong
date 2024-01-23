using System;
using EnhancedUI.EnhancedScroller;
using Game;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class EquipmentItem : MonoBehaviour
    {
        public Button itemBtn;
        public Image iconImg;
        public Image bgImg;
        public Image typeImg;

        private EScrollData _eData;
        private GameDataManager _dataManager => GameDataManager.Instance;

        private void Start()
        {
            itemBtn.onClick.AddListener(OnClickItem);
        }

        private void OnClickItem()
        {
            if (_eData != null)
            {
                ScreenManager.Instance.OpenScreen(ScreenType.EquipmentInfo, _eData);
            }
        }

        public void SetData(ScrollData scrollData)
        {
            if (scrollData == null)
            {
                gameObject.SetActive(false);
            }

            _eData = (EScrollData) scrollData;

            if (_eData != null)
            {
                ShowEquipmentInfo();
            }
        }

        public void SetNone(EquipmentData equipmentData)
        {
            typeImg.sprite = _dataManager.StatDescriptionSO.GetTypeImg(equipmentData);

            iconImg.sprite = _dataManager.StatDescriptionSO.GetTypeImg(equipmentData);
            bgImg.sprite = _dataManager.RankBGSO.OuterBG;
            bgImg.color = _dataManager.RankBGSO.RankColors[0];
            typeImg.sprite = _dataManager.StatDescriptionSO.GetTypeImg(equipmentData);
        }

        private void ShowEquipmentInfo()
        {
            var info = _dataManager.GetItemWithMapID(_eData.MapID);

            var equipmentData = _dataManager.EquipmentSO.GetEquipmentData(info.ID);

            iconImg.sprite = equipmentData.icon;
            bgImg.sprite = _dataManager.RankBGSO.OuterBG;
            bgImg.color = _dataManager.RankBGSO.RankColors[info.Rank];
            typeImg.sprite = _dataManager.StatDescriptionSO.GetTypeImg(equipmentData);
        }
    }
}