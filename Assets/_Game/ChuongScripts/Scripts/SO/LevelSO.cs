using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    [CreateAssetMenu(fileName = "LevelSO", menuName = "ScriptableObjects/LevelSO", order = 1)]
    public class LevelSO : ScriptableObject
    {
        [SerializeField] private List<MapItem> _infoMapItems;
        [SerializeField] private List<int> _listExpLevel;

        public int CountMap => _infoMapItems.Count;

        public MapItem GetMapItem(int mapID)
        {
            var find = _infoMapItems.Find(item => item.mapID == mapID);

            if (find != null)
            {
                return find;
            }

            return _infoMapItems[0];
        }

        [Button]
        public void SetLevelInfo(int count)
        {
            _listExpLevel = new List<int>(count);

            for (int i = 0; i < count; i++)
            {
                _listExpLevel[i] = ((i / 5) + 1) * 50;
            }
        }

        public int GetLevel(int exp, out float expPercent)
        {
            int level = 1;
            expPercent = 0;

            for (int i = 0; i < _listExpLevel.Count; i++)
            {
                if (exp < _listExpLevel[i])
                {
                    expPercent = (float) exp / _listExpLevel[i];
                    break;
                }
                else
                {
                    level++;
                    exp -= _listExpLevel[i];
                }
            }

            return level;
        }
    }

    [Serializable]
    public class MapItem
    {
        public int mapID;

        [FoldoutGroup("Visual")] public string name;
        [FoldoutGroup("Visual")] public string info;
        [FoldoutGroup("Visual")] public Sprite icon;

        [Header("Data")] public DataMap dataMap;
    }

    [Serializable]
    public class DataMap
    {
        public EnemyAttribute EnemyAttribute = new EnemyAttribute()
        {
            MaxHealth = 10,
            Defense = 0,
            Health = 10,
            ExpValue = 1,
            Piority = 1,
            CoinValue = 1,
            Speed = 1,
            Damage = 2
        };

        public int TimeToWin = 10 * 60;
        
        public float AddDMGPerTime = 0.2f, AddHPPerTime = 1.8f;
        public int MaxEnemies = 100;
        public int ZoneSpawnTime = 999;
        public int TimeSpawnBoss = 5;
        public GameObject[] Enemies, Boss;
    }
}