using EnhancedUI.EnhancedScroller;
using UnityEngine;

namespace Game
{
    public class EScrollData : ScrollData
    {
        public int MapID;

        public EScrollData(int mapID)
        {
            MapID = mapID;
        }
    }

    public class EvovleLevelData : ScrollData
    {
        public int level;
        public EvolveState state;
        public string stat;
        public Sprite icon;

        public EvovleLevelData(int i, EvolveState evolveState, string stat, Sprite icon)
        {
            level = i;
            state = evolveState;
            this.stat = stat;
            this.icon = icon;
        }
    }

    public class V2EvovleLevelData : EvovleLevelData
    {
        public V2EvovleLevelData(int i, EvolveState evolveState, string stat, Sprite icon) : base(i, evolveState, stat,
            icon)
        {
        }
    }
}