using Game;

namespace Game
{
    using UnityEngine;

    [System.Serializable]
    public class EnemyAttribute : IHealthAttribute, IMaxHealthAttribute, IDefenseAttribute, IEnemyValueAttribute,
        ISpeedAttribute, IDamageAttribute
    {
        [field: SerializeField] public float Health { get; set; }
        [field: SerializeField] public float MaxHealth { get; set; }
        [field: SerializeField] public float Defense { get; set; }
        [field: SerializeField] public int ExpValue { get; set; }
        [field: SerializeField] public int CoinValue { get; set; }
        [field: SerializeField] public int Piority { get; set; }
        [field: SerializeField] public float Speed { get; set; }
        [field: SerializeField] public float Damage { get; set; }

        internal float GetDamageTaken(float trueDamage)
        {
            return trueDamage;
        }

        internal void MinusHealth(float damageTaken)
        {
            Health -= damageTaken;
        }

        internal void Healing(HealInfo info)
        {
            Health += info.flatHeal + MaxHealth * info.percentageHeal / 100f;
            Health = Mathf.Clamp(Health, 0f, MaxHealth);
        }
    }
}