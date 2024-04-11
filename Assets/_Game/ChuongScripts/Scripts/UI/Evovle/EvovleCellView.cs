using System;
using EnhancedUI;
using EnhancedUI.EnhancedScroller;
using UnityEngine;

namespace Game
{
    public class EvovleCellView : ConstantSizeCellView
    {
        public override Type Type => typeof(EvovleLevelData);

        public override void SetData(ref SmallList<ScrollData> data, int dataIndex)
        {
        }
    }
}