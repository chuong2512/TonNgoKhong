namespace Skill
{
    public interface IPowerPoleAttribute : IAmountAttribute, IDamageAttribute, IPercentDamageAttribute, IMultipleAmountAttribute
    {
    }

    public class PowerPoleAttribute : IPowerPoleAttribute
    {
        public PowerPoleAttribute()
        {
            MultipleAmount = 1;
        }
        
        public int Amount { get; set; }
        public float Damage { get; set; }
        public float PercentDamage { get; set; }
        public int MultipleAmount { get; set; }
    }
}