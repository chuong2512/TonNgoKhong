namespace Game
{
    public interface IPowerPoleAttribute : IAmountAttribute, IPlayerDamageAttribute, IPercentDamageAttribute, 
        IMultipleAmountAttribute, ISpeedAttribute, ISpeedShotAttribute
    {
    }

    public class PowerPoleAttribute : ShotWeaponAttribute
    {
        public PowerPoleAttribute()
        {
            MultipleAmount = 1;
        }
    }
    
    public class SwordAttribute : ShotWeaponAttribute
    {
        public SwordAttribute()
        {
            MultipleAmount = 1;
        }
    }
    
    public class ShotWeaponAttribute : IPowerPoleAttribute
    {
        public ShotWeaponAttribute()
        {
            MultipleAmount = 1;
        }
        
        public int Amount { get; set; }
        public float Damage { get; set; }
        public float PercentDamage { get; set; }
        public int MultipleAmount { get; set; }
        public float Speed { get; set; }
        public float SpeedShot { get; set; }
    }
}