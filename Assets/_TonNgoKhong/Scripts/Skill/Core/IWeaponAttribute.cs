namespace Skill
{
    public interface IWeaponAttribute
    {
        
    }

    public interface IAmountAttribute : IWeaponAttribute
    {
        int Amount { get; set; }
    }
    
    public interface IDamageAttribute : IWeaponAttribute
    {
        float Damage { get; set; }
    }
}