using EnhancedUI.EnhancedScroller;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class EquipmentIcon : MonoBehaviour
    {
        public Image iconImg;
        public Image bgImg;
        public Image typeImg;
        public TextMeshProUGUI levelTMP;

        protected EScrollData _eData;
        private GameDataManager _dataManager => GameDataManager.Instance;


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
            _eData = null;

            typeImg.sprite = _dataManager.StatDescriptionSO.GetTypeImg(equipmentData);
            iconImg.sprite = _dataManager.StatDescriptionSO.GetTypeImg(equipmentData);
            bgImg.sprite = _dataManager.RankBGSO.OuterBG;
            bgImg.color = _dataManager.RankBGSO.RankColors[0];
            typeImg.sprite = _dataManager.StatDescriptionSO.GetTypeImg(equipmentData);
            levelTMP?.SetText("");
        }

        private void ShowEquipmentInfo()
        {
            var info = _dataManager.GetItemWithMapID(_eData.MapID);

            var equipmentData = _dataManager.EquipmentSO.GetEquipmentData(info.ID);

            iconImg.sprite = equipmentData.icon;
            bgImg.sprite = _dataManager.RankBGSO.OuterBG;
            bgImg.color = _dataManager.RankBGSO.RankColors[info.Rank];
            typeImg.sprite = _dataManager.StatDescriptionSO.GetTypeImg(equipmentData);
            levelTMP?.SetText($"Lv.{info.Level + 1}");
        }

        protected void ShowInfoWithID(int ID)
        {
            var equipmentData = _dataManager.EquipmentSO.GetEquipmentData(ID);

            iconImg.sprite = equipmentData.icon;
            bgImg.sprite = _dataManager.RankBGSO.OuterBG;
            bgImg.color = _dataManager.RankBGSO.RankColors[0];
            typeImg.sprite = _dataManager.StatDescriptionSO.GetTypeImg(equipmentData);
            levelTMP?.SetText("Lv.1");
        }
    }
}