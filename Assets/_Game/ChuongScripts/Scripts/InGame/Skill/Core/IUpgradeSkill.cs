using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game
{
    public interface IUpgradeSkill
    {
        void Upgrade(IAttribute weaponBuilder);
    }

    public interface IMultiple
    {
        float Multipler { get; set; }
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

        public AmountUpgrade()
        {
        }

        public AmountUpgrade(int amount)
        {
            this.amount = amount;
        }

        public void Upgrade(IAmountAttribute weaponAttribute)
        {
            weaponAttribute.Amount += amount;
        }
    }

    [Serializable]
    public class AddDamageUpgrade : IUpgradeSkill<IDamageAttribute>
    {
        [SerializeField] private float addDamage;

        public AddDamageUpgrade()
        {
        }

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

    [Serializable]
    public class PlayerSpeedUpgrade : IUpgradeSkill<IPlayerSpeedAttribute>
    {
        [SerializeField] private float addSpeed;

        public void Upgrade(IPlayerSpeedAttribute playerAtt)
        {
            playerAtt.Speed += addSpeed;
        }
    }

    [Serializable]
    public class ShotSpeedUpgrade : IUpgradeSkill<IPlayerSpeedAttribute>
    {
        [SerializeField] private float addSpeed;

        public void Upgrade(IPlayerSpeedAttribute playerAtt)
        {
            playerAtt.Speed += addSpeed;
        }
    }

    [Serializable]
    public class MagnetUpgrade : IUpgradeSkill<IMagnetAttribute>
    {
        [SerializeField] private float addMagnetRange;

        public void Upgrade(IMagnetAttribute weaponBuilder)
        {
            weaponBuilder.Magnet += addMagnetRange;
        }
    }

    [Serializable]
    public class HPUpgrade : IUpgradeSkill<IMaxHealthAttribute>
    {
        [SerializeField] private float hp;

        public HPUpgrade(float HP)
        {
            hp = HP;
        }

        public HPUpgrade()
        {
        }

        public void Upgrade(IMaxHealthAttribute weaponBuilder)
        {
            weaponBuilder.MaxHealth += hp;
        }
    }

    [Serializable]
    public class SpeedShotUpgrade : IUpgradeSkill<ISpeedShotAttribute>
    {
        [SerializeField] private float speed;

        public void Upgrade(ISpeedShotAttribute weaponBuilder)
        {
            weaponBuilder.SpeedShot += speed;
        }
    }

    [Serializable]
    public class IDefenseUpgrade : IUpgradeSkill<IDefenseAttribute>
    {
        [SerializeField] private float def;

        public IDefenseUpgrade(float def)
        {
            this.def = def;
        }

        public void Upgrade(IDefenseAttribute weaponBuilder)
        {
            weaponBuilder.Defense += def;
        }
    }

    [Serializable]
    public class RangeUpgrade : IUpgradeSkill<IRangeAttribute>
    {
        [SerializeField] private float range;

        public void Upgrade(IRangeAttribute weaponBuilder)
        {
            weaponBuilder.Range += range;
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