using System;

namespace Game
{
    using UnityEngine;
    using UnityEngine.Serialization;

    public struct DamageInfo
    {
        public float trueDamage;
        public float defPenetrationRate;
        public float defPenetrationPowerRate;
        public Vector3 positionContact;
        public float damageByHpPercent;

        public DamageInfo(float trueDamage, float damageByHpPercent, float defPenetrationRate,
            float defPenetrationPowerRate, Vector3 positionContact)
        {
            this.trueDamage = trueDamage;
            this.defPenetrationRate = defPenetrationRate;
            this.defPenetrationPowerRate = defPenetrationPowerRate;
            this.positionContact = positionContact;
            this.damageByHpPercent = damageByHpPercent;
        }

        public DamageInfo(float trueDamage, float damageByHpPercent, float defPenetrationRate,
            float defPenetrationPowerRate) : this(trueDamage, damageByHpPercent, defPenetrationRate,
            defPenetrationPowerRate, Vector3.zero)
        {
        }

        public DamageInfo(float trueDamage, float damageByHpPercent) : this(trueDamage, damageByHpPercent, 0f, 0f)
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
        /*void TakeAffectDamage(DamageInfo damageInfo);
        void TakeAffect(Type affectType);*/
        bool IsDestroyed();
    }
}