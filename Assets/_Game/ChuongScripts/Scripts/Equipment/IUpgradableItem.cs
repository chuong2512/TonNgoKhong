namespace Game
{
    public interface IUpgradableItem
    {
        public int Level { get; set; }
    }

    public interface IEquipment : IUpgradableItem
    {
        public int ID { get; set; }
        public int MapID { get; set; }

        public void UpgradeLevel()
        {
            Level += 1;
        }
    }

    public class Necklace : IEquipment
    {
        public int Level { get; set; }

        public int ID { get; set; }
        public int MapID { get; set; }
    }

    public class Armor : IEquipment
    {
        public int Level { get; set; }

        public int ID { get; set; }
        public int MapID { get; set; }
    }

    public class Glove : IEquipment
    {
        public int Level { get; set; }

        public int ID { get; set; }
        public int MapID { get; set; }
    }

    public class Shoe : IEquipment
    {
        public int Level { get; set; }

        public int ID { get; set; }
        public int MapID { get; set; }
    }

    public class Ring : IEquipment
    {
        public int Level { get; set; }

        public int ID { get; set; }
        public int MapID { get; set; }
    }
}