using System.Collections.Generic;

namespace Game
{
    public partial class GameDataManager
    {
        public List<AEquipment> Equipments => inventoryData.Equipments;

        public int CurrentNecklace
        {
            get => inventoryData.CurrentNecklace;
            set => inventoryData.CurrentNecklace = value;
        }

        public int CurrentArmor
        {
            get => inventoryData.CurrentArmor;
            set => inventoryData.CurrentArmor = value;
        }

        public int CurrentGlove
        {
            get => inventoryData.CurrentGlove;
            set => inventoryData.CurrentGlove = value;
        }

        public int CurrentRing
        {
            get => inventoryData.CurrentRing;
            set => inventoryData.CurrentRing = value;
        }

        public int CurrentShoe
        {
            get => inventoryData.CurrentShoe;
            set => inventoryData.CurrentShoe = value;
        }

        public void AddItem(AEquipment equipment)
        {
            equipment.MapID = inventoryData.mapID;
            inventoryData.mapID++;

            Equipments.Add(equipment);

            inventoryData.SaveData();
        }

        public void AddItem(int ID)
        {
            var eData = EquipmentSO.GetEquipmentData(ID);

            var e = eData.CreateEquipment();

            AddItem(e);
            inventoryData.SaveData();
        }

        public void AddItemWithRank(int ID, int rank)
        {
            var eData = EquipmentSO.GetEquipmentData(ID);

            var e = eData.CreateEquipment();

            e.Rank = rank;

            AddItem(e);
            inventoryData.SaveData();
        }

        public AEquipment GetItemWithMapID(int mapID)
        {
            var find = Equipments.Find(equipment => equipment.MapID == mapID);
            return find;
        }

        public void RemoveItem(int mapID)
        {
            var item = GetItemWithMapID(mapID);
            RemoveItem(item);
            inventoryData.SaveData();
        }

        public void RemoveItem(AEquipment equipment)
        {
            if (equipment != null)
            {
                Equipments.Remove(equipment);
            }

            inventoryData.SaveData();
        }

        public bool IsUsingMapID(int mapID)
        {
            if (mapID < 0)
            {
                return false;
            }

            if (CurrentNecklace == mapID)
                return true;
            if (CurrentGlove == mapID)
                return true;
            if (CurrentRing == mapID)
                return true;
            if (CurrentShoe == mapID)
                return true;
            if (CurrentArmor == mapID)
                return true;

            return false;
        }

        public bool UpgradeLevelEquipment(IEquipment equipment)
        {
            if (equipment != null)
            {
                var eData = EquipmentSO.GetEquipmentData(equipment.ID);

                if (equipment.Level >= eData.MaxLevel) return false;
                equipment.UpgradeLevel();
                inventoryData.SaveData();
                return true;
            }

            return false;
        }

        public void UpgradeRankEquipment(IEquipment equipment)
        {
            if (equipment != null)
            {
                var eData = EquipmentSO.GetEquipmentData(equipment.ID);

                if (equipment.Rank < eData.MaxRank)
                {
                    equipment.UpgradeRank();
                }
            }

            inventoryData.SaveData();
        }

        public List<AEquipment> Necklaces => Equipments.FindAll(equipment => equipment is Necklace);
        public List<AEquipment> Armors => Equipments.FindAll(equipment => equipment is Armor);
        public List<AEquipment> Gloves => Equipments.FindAll(equipment => equipment is Glove);
        public List<AEquipment> Shoes => Equipments.FindAll(equipment => equipment is Shoe);
        public List<AEquipment> Rings => Equipments.FindAll(equipment => equipment is Ring);
    }
}