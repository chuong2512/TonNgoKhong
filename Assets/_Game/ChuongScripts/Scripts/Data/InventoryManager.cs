using System.Collections.Generic;

namespace Game
{
    public partial class GameDataManager
    {
        public List<IEquipment> Equipments => inventoryData.Equipments;

        public void AddItem(IEquipment equipment)
        {
            equipment.MapID = inventoryData.mapID;
            inventoryData.mapID++;

            Equipments.Add(equipment);
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

        public List<IEquipment> Necklaces => Equipments.FindAll(equipment => equipment is Necklace);
        public List<IEquipment> Armors => Equipments.FindAll(equipment => equipment is Armor);
        public List<IEquipment> Gloves => Equipments.FindAll(equipment => equipment is Glove);
        public List<IEquipment> Shoes => Equipments.FindAll(equipment => equipment is Shoe);
        public List<IEquipment> Rings => Equipments.FindAll(equipment => equipment is Ring);
    }
}