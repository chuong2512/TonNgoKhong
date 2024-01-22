using System;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class EquipmentManager : MonoBehaviour
    {
        public CurrentEquipment CurrentEquipment;
        public Button MergeBtn, SortBtn;

        private GameDataManager _gameDataManager;

        private void Start()
        {
            MergeBtn?.onClick.AddListener(OnClickMerge);
            SortBtn?.onClick.AddListener(OnClickSort);

            _gameDataManager = GameDataManager.Instance;
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
        }

        private void OnEnable()
        {
            LoadData();
        }

        private void LoadData()
        {
            CurrentEquipment.BindData();
        }
    }
}