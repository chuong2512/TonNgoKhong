using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game
{
    public interface IEquipmentUpgrade : IUpgradeSkill, IMultiple
    {
        string StatName { get; }
        string StatValue { get; }
    }

    public interface IEquipmentUpgrade<in T> : IEquipmentUpgrade where T : IAttribute
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
    public class HPEquipment : IEquipmentUpgrade<IMaxHealthAttribute>
    {
        [SerializeField] private float hp;

        public HPEquipment(float HP)
        {
            hp = HP;
        }
        
        public HPEquipment()
        {
        }

        public void Upgrade(IMaxHealthAttribute weaponBuilder)
        {
            weaponBuilder.MaxHealth += hp * Multipler;
        }

        public string StatName => "Tăng máu";
        public string StatValue => $"+{(hp * Multipler):F1}";

        public float Multipler { get; set; }
    }

    [Serializable]
    public class DamageEquipment : IEquipmentUpgrade<IDamageAttribute>
    {
        [SerializeField] private float dmg;

        public DamageEquipment()
        {
        }

        public DamageEquipment(float dmg)
        {
            this.dmg = dmg;
        }


        public void Upgrade(IDamageAttribute weaponBuilder)
        {
            weaponBuilder.Damage += dmg * Multipler;
        }

        public string StatName => "Tăng tấn công";
        public string StatValue => $"+{(dmg * Multipler):F0}";

        public float Multipler { get; set; }
    }
}