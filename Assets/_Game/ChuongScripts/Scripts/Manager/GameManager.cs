using SinhTon;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public partial class GameManager : PersistentSingleton<GameManager>
    {
        private GameDataManager _gameData;
        private ScreenManager _uiManager;

        private void Start()
        {
            BindData();
        }

        private void BindData()
        {
            _gameData = GameDataManager.Instance;
            _uiManager = ScreenManager.Instance;
        }

        [Button]
        public void AddEquipment(int ID)
        {
            _gameData.AddItem(ID);
        }
    }
}