namespace Game
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

    
    public interface IPlayerDamageAttribute : IDamageAttribute
    {
    }

    public interface IPercentDamageAttribute : IAttribute
    {
        float PercentDamage { get; set; }
    }

    public interface ILifeTimeAttribute : IAttribute
    {
        float LifeTime { get; set; }
    }

    public interface ISpeedAttribute : IAttribute
    {
        float Speed { get; set; }
    }
    
    public interface ISpeedShotAttribute : IAttribute
    {
        float SpeedShot { get; set; }
    }

    public interface IShotSpeedAttribute : ISpeedAttribute
    {
    }

    public interface IPlayerSpeedAttribute : ISpeedAttribute
    {
    }

    public interface IMultipleAmountAttribute : IAttribute
    {
        int MultipleAmount { get; set; }
    }

    public interface IHealthAttribute : IAttribute
    {
        float Health { get; set; }
    }

    public interface IMaxHealthAttribute : IAttribute
    {
        float MaxHealth { get; set; }
    }

    public interface IVirtualHealthAttribute : IAttribute
    {
        float VirtualHealth { get; set; }
    }

    public interface IDefenseAttribute : IAttribute
    {
        float Defense { get; set; }
    }

    public interface ICritChanceAttribute : IAttribute
    {
        float CritChance { get; set; }
    }

    public interface ICritMultAttribute : IAttribute
    {
        float CritMult { get; set; }
    }

    public interface IMagnetAttribute : IAttribute
    {
        float Magnet { get; set; }
    }

    public interface IEnemyValueAttribute : IAttribute
    {
        int ExpValue { get; set; }
        int CoinValue { get; set; }
        int Piority { get; set; }
    }
    
    public interface IRangeAttribute : IAttribute
    {
        float Range { get; set; }
    }
}