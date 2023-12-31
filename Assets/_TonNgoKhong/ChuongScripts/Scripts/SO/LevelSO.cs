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

        public MapItem GetMapItem(int mapID)
        {
            return _infoMapItems.Find(item => item.mapID == mapID);
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