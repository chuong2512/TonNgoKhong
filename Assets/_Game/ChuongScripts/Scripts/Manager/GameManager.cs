using SinhTon;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public static class GameConstant
    {
        public static readonly int TimeWin = 15 * 60;
    }

    public partial class GameManager : PersistentSingleton<GameManager>
    {
        private GameDataManager _gameData => GameDataManager.Instance;
        private ScreenManager _uiManager => ScreenManager.Instance;

        [Button]
        public void AddEquipment(int ID, int rank)
        {
            _gameData.AddItemWithRank(ID, rank);
        }

        [Button]
        public void EndLevel(bool b)
        {
            ScreenManager.Instance.OpenScreen(ScreenType.Result, new ResultModel(b));
        }
    }
}