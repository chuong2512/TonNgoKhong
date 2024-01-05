namespace Skill
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
        public abstract SuppliesType SuppliesType { get; }
    }
}