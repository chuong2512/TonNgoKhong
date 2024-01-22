using System;
using EnhancedUI.EnhancedScroller;
using Jackal;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class EquipmentItem : MonoBehaviour
    {
        public Button itemBtn;
        public Image iconImg;
        public Image bgImg;
        public EquipmentStat equipmentStat;
        
        
        private EScrollData _eData;
        private GameDataManager _dataManager;

        private void Start()
        {
            _dataManager = GameDataManager.Instance;

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

        private void ShowEquipmentInfo()
        {
            var info = _dataManager.GetItemWithMapID(_eData.MapID);

            var equipmentData = _dataManager.EquipmentSO.GetEquipmentData(info.ID);

            iconImg.sprite = equipmentData.icon;
            bgImg.sprite = _dataManager.RankBGSO.OuterBG;
            bgImg.color = _dataManager.RankBGSO.RankColors[info.Rank];
            
           equipmentStat.SetStat(_dataManager.EquipmentSO.GetListUpgradeSkill(info)[0]);
        }
    }
}