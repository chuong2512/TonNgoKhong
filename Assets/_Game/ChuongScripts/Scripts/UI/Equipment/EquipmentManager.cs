using System;
using EnhancedUI;
using EnhancedUI.EnhancedScroller;
using Game;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class EquipmentManager : MonoBehaviour
    {
        public CurrentEquipment CurrentEquipment;
        public Button MergeBtn, SortBtn;
        public AdvanceScrollView AdvanceScrollView;

        private GameDataManager _gameDataManager => GameDataManager.Instance;

        private void Start()
        {
            MergeBtn?.onClick.AddListener(OnClickMerge);
            SortBtn?.onClick.AddListener(OnClickSort);

            OutGameAction.ChangeEquipment += ChangeEquipment;
        }

        private void ChangeEquipment()
        {
            LoadData();
        }

        private void OnClickMerge()
        {
        }

        private void OnClickSort()
        {
        }

        private void OnDestroy()
        {
            MergeBtn?.onClick.RemoveAllListeners();
            SortBtn?.onClick.RemoveAllListeners();

            OutGameAction.ChangeEquipment -= ChangeEquipment;
        }

        private void OnEnable()
        {
            LoadData();
        }

        private void LoadData()
        {
            CurrentEquipment.BindData();

            var listData = new SmallList<ScrollData>();

            for (int i = 0; i < _gameDataManager.Equipments.Count; i++)
            {
                var e = _gameDataManager.Equipments[i];

                if (!_gameDataManager.IsUsingMapID(e.MapID))
                {
                    listData.Add(new EScrollData(e.MapID));
                }
            }

            AdvanceScrollView.LoadData(listData);
        }
    }
}