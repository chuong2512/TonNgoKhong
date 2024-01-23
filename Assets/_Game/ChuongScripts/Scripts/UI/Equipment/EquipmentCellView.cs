using System;
using EnhancedUI;
using EnhancedUI.EnhancedScroller;
using Game;

public class EquipmentCellView : ConstantSizeCellView
{
    public EquipmentItem[] Items;
    public override Type Type => typeof(EScrollData);

    public override void SetData(ref SmallList<ScrollData> data, int dataIndex)
    {
        for (int i = 0; i < Items.Length; i++)
        {
            var index = dataIndex + i;

            if (index < data.Count)
            {
                Items[i].gameObject.SetActive(true);
                Items[i].SetData(data[index]);
            }
            else
            {
                Items[i].gameObject.SetActive(false);
            }
        }
    }
}