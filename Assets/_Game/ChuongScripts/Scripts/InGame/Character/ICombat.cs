using System;

namespace Game
{
    using UnityEngine;
    using UnityEngine.Serialization;

    public struct DamageInfo
    {
        public float trueDamage;
        public Vector3 positionContact;
        public float damageByHpPercent;

        public DamageInfo(float trueDamage, float damageByHpPercent, Vector3 positionContact)
        {
            this.trueDamage = trueDamage;
            this.positionContact = positionContact;
            this.damageByHpPercent = damageByHpPercent;
        }

        public DamageInfo(float trueDamage, float damageByHpPercent) : this(trueDamage, damageByHpPercent, Vector3.zero)
        {
        }
        
        public DamageInfo(float trueDamage) : this(trueDamage, 0, Vector3.zero)
        {
        }
    }


    public struct HealInfo
    {
        public float flatHeal;
        public float percentageHeal; // 0-100
        public float healLostByPercent;

        public HealInfo(float flatHeal, float percentageHeal, float healLostByPercent = 0)
        {
            this.flatHeal = flatHeal;
            this.percentageHeal = percentageHeal;
            this.healLostByPercent = healLostByPercent;
        }
    }

    public interface ICombat
    {
        void TakeHeal(HealInfo healInfo);
        void TakeDamage(DamageInfo damageInfo);
        void TakeDamageByHealthPercent(float healthPercent);
        void TakeDamage(float trueDamage);
        bool IsDestroyed();
    }
}