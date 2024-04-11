using EnhancedUI.EnhancedScroller;

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

    public class EvovleLevelData: ScrollData
    {
        public int level;
    }
    
    public class V2EvovleLevelData : EvovleLevelData
    {
        
    }
}