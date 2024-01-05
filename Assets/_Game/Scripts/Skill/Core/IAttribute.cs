namespace Skill
{
    public interface IAttribute
    {
        
    }

    public interface IAmountAttribute : IAttribute
    {
        int Amount { get; set; }
    }
    
    public interface IDamageAttribute : IAttribute
    {
        float Damage { get; set; }
    }
}