using Skill;

namespace Game
{
    using UnityEngine;

    [System.Serializable]
    public class EnemyAttribute : IHealthAttribute, IMaxHealthAttribute, IDefenseAttribute
    {
        [field: SerializeField] public float Health { get; set; }
        [field: SerializeField]public float MaxHealth { get; set; }
        [field: SerializeField]public float Defense { get; set; }


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