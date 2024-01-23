using SinhTon;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public partial class GameManager : PersistentSingleton<GameManager>
    {
        private GameDataManager _gameData => GameDataManager.Instance;
        private ScreenManager _uiManager => ScreenManager.Instance;

        [Button]
        public void AddEquipment(int ID)
        {
            _gameData.AddItem(ID);
        }
    }
}