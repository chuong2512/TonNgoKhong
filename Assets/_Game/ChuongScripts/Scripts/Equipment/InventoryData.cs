using System;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class InventoryData : BaseData
{
    public int mapID;

    [SubclassSelector, SerializeReference] 
    public List<AEquipment> Equipments;

    public int CurrentNecklace,
        CurrentArmor,
        CurrentGlove,
        CurrentShoe,
        CurrentRing;

    public override void Init()
    {
        prefString = Constant.DataKey_InventoryData;

        if (PlayerPrefs.GetString(prefString).Equals(""))
        {
            ResetData();
        }

        base.Init();
    }

    public override void ResetData()
    {
        Equipments = new List<AEquipment>();

        CurrentNecklace = -1;
        CurrentArmor = -1;
        CurrentGlove = -1;
        CurrentShoe = -1;
        CurrentRing = -1;

        Save();
    }

    public override void ValidateData()
    {
        Equipments ??= new List<AEquipment>();

        if (Equipments.Count != 0) return;
        CurrentNecklace = -1;
        CurrentArmor = -1;
        CurrentGlove = -1;
        CurrentShoe = -1;
        CurrentRing = -1;
    }

    public void SaveData()
    {
        Save();
    }
}