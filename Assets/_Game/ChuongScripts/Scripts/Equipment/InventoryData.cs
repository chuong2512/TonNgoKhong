using System.Collections;
using System.Collections.Generic;
using Game;

public class InventoryData : BaseData
{
    public int mapID;
    public List<IEquipment> Equipments;

    public int CurrentNecklace,
        CurrentArmor,
        CurrentGlove,
        CurrentShoe,
        CurrentRing;

    public override void Init()
    {
        base.Init();

        Equipments = new List<IEquipment>();

        CurrentNecklace = -1;
        CurrentArmor = -1;
        CurrentGlove = -1;
        CurrentShoe = -1;
        CurrentRing = -1;
    }

    public override void ValidateData()
    {
        Equipments ??= new List<IEquipment>();

        if (Equipments.Count != 0) return;
        CurrentNecklace = -1;
        CurrentArmor = -1;
        CurrentGlove = -1;
        CurrentShoe = -1;
        CurrentRing = -1;
    }
}