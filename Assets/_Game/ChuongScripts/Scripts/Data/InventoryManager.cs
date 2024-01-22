using System.Collections.Generic;

namespace Game
{
    public partial class GameDataManager
    {
        public List<IEquipment> Equipments => inventoryData.Equipments;

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

        public void AddItem(IEquipment equipment)
        {
            equipment.MapID = inventoryData.mapID;
            inventoryData.mapID++;

            Equipments.Add(equipment);
        }

        public void AddItem(int ID)
        {
            var eData = EquipmentSO.GetEquipmentData(ID);

            var e = eData.CreateEquipment();

            AddItem(e);
        }
        
        public void AddItemWithRank(int ID, int rank)
        {
            var eData = EquipmentSO.GetEquipmentData(ID);

            var e = eData.CreateEquipment();

            e.Rank = rank;
            
            AddItem(e);
        }

        public IEquipment GetItemWithMapID(int mapID)
        {
            var find = Equipments.Find(equipment => equipment.MapID == mapID);
            return find;
        }

        public void UpgradeItem(int mapID)
        {
        }

        public void RemoveItem(int mapID)
        {
            var item = GetItemWithMapID(mapID);
            RemoveItem(item);
        }

        public void RemoveItem(IEquipment equipment)
        {
            if (equipment != null)
            {
                Equipments.Remove(equipment);
            }
        }

        public void UpgradeLevelEquipment(IEquipment equipment)
        {
            if (equipment != null)
            {
                var eData = EquipmentSO.GetEquipmentData(equipment.ID);

                if (equipment.Level < eData.MaxLevel)
                {
                    equipment.UpgradeLevel();
                }
            }
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
        }

        public List<IEquipment> Necklaces => Equipments.FindAll(equipment => equipment is Necklace);
        public List<IEquipment> Armors => Equipments.FindAll(equipment => equipment is Armor);
        public List<IEquipment> Gloves => Equipments.FindAll(equipment => equipment is Glove);
        public List<IEquipment> Shoes => Equipments.FindAll(equipment => equipment is Shoe);
        public List<IEquipment> Rings => Equipments.FindAll(equipment => equipment is Ring);
    }
}