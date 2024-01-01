using System;
using UnityEngine;

namespace Skill
{
    public interface IUpgradeSkill
    {
        void Upgrade(object weaponBuilder);
    }
    
    public interface IUpgradeSkill<in T> : IUpgradeSkill where T : IWeaponAttribute
    {
        void IUpgradeSkill.Upgrade(object @object)
        {
            if (@object is not T weaponBuilder)
            {
#if UNITY_EDITOR
                Debug.Log($"{@object.GetType()} is not match {typeof(T)}");
#endif
                return;
            }
            Upgrade(weaponBuilder);
        }
        void Upgrade(T weaponBuilder);
    }

    [Serializable]
    public class AmountUpgrade : IUpgradeSkill<IAmountAttribute>
    {
        [SerializeField] private int amount;

        public AmountUpgrade() { }

        public AmountUpgrade(int amount)
        {
            this.amount = amount;
        }
        
        public void Upgrade(IAmountAttribute weaponAttribute)
        {
            weaponAttribute.Amount = amount;
        }
    }
    
    [Serializable]
    public class AddDamageUpgrade : IUpgradeSkill<IDamageAttribute>
    {
        [SerializeField] private float addDamage;

        public AddDamageUpgrade() { }

        public AddDamageUpgrade(float addDamage)
        {
            this.addDamage = addDamage;
        }

        public void Upgrade(IDamageAttribute weaponAttribute)
        {
            weaponAttribute.Damage += addDamage;
        }
    }
    
    [Serializable]
    public class AddRateDamageUpgrade : IUpgradeSkill<IDamageAttribute>
    {
        [SerializeField] private float rate;
        public void Upgrade(IDamageAttribute weaponAttribute)
        {
            weaponAttribute.Damage *= (1f + rate);
        }
    }
}