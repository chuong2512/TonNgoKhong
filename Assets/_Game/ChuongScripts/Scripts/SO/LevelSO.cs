using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace _TonNgoKhong
{
    [CreateAssetMenu(fileName = "LevelSO", menuName = "ScriptableObjects/LevelSO", order = 1)]
    public class LevelSO : ScriptableObject
    {
        [SerializeField] private List<MapItem> _infoMapItems;
        [SerializeField] private List<int> _listExpLevel;

        public MapItem GetMapItem(int mapID)
        {
            return _infoMapItems.Find(item => item.mapID == mapID);
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

        public bool isLock;
    }
}