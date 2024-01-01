namespace Skill
{
    public interface ISkill
    {
        int Level { get; }
        int HashID { get; }
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