namespace Game
{
    public interface IInfoSkill
    {
        int Level { get; }
        int HashID { get; }
    }

    public interface IUpgradable
    {
        void Upgrade();
    }

    public interface ISkill
    {
    }

    public interface IWeaponSkill : ISkill
    {
        WeaponType WeaponType { get; }
        void ActiveWeapon();
    }

    public interface ISuppliesSkill : ISkill
    {
        public void Apply<T>(T attribute) where T : IAttribute;
        public SuppliesType SuppliesType { get; }
    }
}