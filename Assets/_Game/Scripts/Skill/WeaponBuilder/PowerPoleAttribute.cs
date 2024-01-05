namespace Skill
{
    public interface IPowerPoleAttribute : IAmountAttribute, IDamageAttribute
    {
    }

    public class PowerPoleAttribute : IPowerPoleAttribute
    {
        public int Amount { get; set; }
        public float Damage { get; set; }
    }
}