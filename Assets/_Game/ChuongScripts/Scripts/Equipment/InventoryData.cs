using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class InventoryData : BaseData
{
    public int mapID;
    public List<IEquipment> Equipments;

    public override void Init()
    {
        base.Init();

        Equipments = new List<IEquipment>();
    }

    public override void ValidateData()
    {
        Equipments ??= new List<IEquipment>();
    }
}