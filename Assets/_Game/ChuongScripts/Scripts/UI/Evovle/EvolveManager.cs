using System;
using EnhancedUI;
using EnhancedUI.EnhancedScroller;
using JetBrains.Annotations;
using UnityEngine;

namespace Game
{
    public class EvolveManager : MonoBehaviour
    {
        public AdvanceScrollView AdvanceScrollView;
        private GameDataManager _gameDataManager => GameDataManager.Instance;

        private void Awake()
        {
            OutGameAction.UpgradeEvolve += UpgradeEvolve;
        }

        private void OnDestroy()
        {
            OutGameAction.UpgradeEvolve -= UpgradeEvolve;
        }

        private void UpgradeEvolve()
        {
            LoadData();
        }

        private void OnEnable()
        {
            LoadData();
        }

        private void LoadData()
        {
            var listData = new SmallList<ScrollData>();

            var currentLevel = _gameDataManager.evolveData.evolveLevel;

            var levels = _gameDataManager.EvolveSo.levels;

            for (int i = levels.Length - 1; i >= 0; i--)
            {
                var state = EvolveState.Lock;

                if (currentLevel == i)
                {
                    state = EvolveState.Current;
                }
                else if (currentLevel > i)
                {
                    state = EvolveState.Unlock;
                }

                var stat = _gameDataManager.EvolveSo.GetEvolveStat(i);

                var statString = $"{stat.name} +{levels[i].value}";

                listData.Add(new EvovleLevelData(i, state, statString, stat.icon));
            }

            AdvanceScrollView.LoadData(listData, levels.Length - 3 - currentLevel);
        }
    }

    public enum EvolveState
    {
        Lock,
        Unlock,
        Current
    }
}