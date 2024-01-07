using System;
using UnityEngine;

namespace Skill
{
    public interface IUpgradeSkill
    {
        void Upgrade(IAttribute weaponBuilder);
    }
    
    public interface IUpgradeSkill<in T> : IUpgradeSkill where T : IAttribute
    {
        void IUpgradeSkill.Upgrade(IAttribute @object)
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
    
    /*[Serializable]
    public class AddBlueFire : IUpgradeSkill<IFireAttribute>
    {
        public void Upgrade(IFireAttribute weaponBuilder)
        {
            weaponBuilder.Update(new BlueFire());
        }
    }
    
    public interface IFireAttribute : IAttribute
    {
        IFire _fire { get; }

        void Update<T>(T fire) where T : IFire;
    }

    public class fireAttack : IFireAttribute
    {
        public IFire _fire { get; private set; }
        public void Update<T>(T fire) where T : IFire
        {
            _fire = fire;
        }
    }

    public interface IFire
    {
        
    }

    public class BlueFire : IFire
    {
        
    }*/
}