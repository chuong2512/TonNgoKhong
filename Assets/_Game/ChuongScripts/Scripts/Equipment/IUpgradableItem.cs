using System;

namespace Game
{
    public interface IUpgradableItem
    {
        public int Level { get; set; }
        public int Rank { get; set; }
    }

    [Serializable]
    public abstract class AEquipment : IEquipment
    {
        public int _level;
        public int _rank;
        public int _id;
        public int _mapID;

        public int Level
        {
            get => _level;
            set => _level = value;
        }

        public int Rank
        {
            get => _rank;
            set => _rank = value;
        }

        public int ID
        {
            get => _id;
            set => _id = value;
        }

        public int MapID
        {
            get => _mapID;
            set => _mapID = value;
        }
    }

    public interface IEquipment : IUpgradableItem
    {
        public int ID { get; set; }
        public int MapID { get; set; }

        public void UpgradeLevel()
        {
            Level += 1;
        }

        public void UpgradeRank()
        {
            Rank += 1;
        }
    }

    [Serializable]
    public class Necklace : AEquipment
    {
    }

    [Serializable]
    public class Armor : AEquipment
    {
    }

    [Serializable]
    public class Glove : AEquipment
    {
    }

    [Serializable]
    public class Shoe : AEquipment
    {
    }

    [Serializable]
    public class Ring : AEquipment
    {
    }
}