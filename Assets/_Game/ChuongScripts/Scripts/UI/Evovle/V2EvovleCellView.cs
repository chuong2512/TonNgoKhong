using System;
using EnhancedUI;
using EnhancedUI.EnhancedScroller;
using UnityEngine;

namespace Game
{
    public class V2EvovleCellView : EvovleCellView
    {
        public override Type Type => typeof(V2EvovleLevelData);

        public override void SetData(ref SmallList<ScrollData> data, int dataIndex)
        {
        }
    }
}