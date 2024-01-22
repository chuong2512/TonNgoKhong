using System;
using System.Collections.Generic;
using SinhTon;
using UnityEngine;

namespace Game
{
    public static class HashIDSkill
    {
        private static readonly Type[] HashList = 
        {
            typeof(WeaponType),
            typeof(SuppliesType)
        };
        
        private static readonly Dictionary<Type, (int min, int amount)> RangeSkillType = new();
        private static readonly Dictionary<Enum, int> _skillHashID = new();
        private static readonly Dictionary<int, Enum> _skillValues = new();

        public static void InitData()
        {
            var count = 0;
            foreach (var type in HashList)
            {
#if UNITY_EDITOR
                if (!type.IsEnum)
                {
                    Debug.LogError($"{type} is not match Enum type");
                    continue;
                }
#endif
                var enumValues = Enum.GetValues(type);
                var amount = enumValues.Length;
                RangeSkillType[type] =(count, amount);
                foreach (Enum value in enumValues)
                {
#if UNITY_EDITOR
                    Debug.Log($"{type} {value} {count + Convert.ToInt32(value)}");
#endif
                    var id = count + Convert.ToInt32(value);
                    _skillHashID[value] = id;
                    _skillValues[id] = value;
                }
                count += amount;
            }
        }
        

        public static void GetSkillTypeValues<T>(out T[] skills) where T : Enum
        {
            var type = typeof(T);
            if (!RangeSkillType.ContainsKey(type))
            {
                Debug.LogError($"{type} is not exist in Skill Type");
                skills = null;
            }
            skills = (T[])Enum.GetValues(type);
        }
        
        public static int GetSkillAmount(Type skillType)
        {
            if (!RangeSkillType.ContainsKey(skillType))
            {
                Debug.LogError($"{skillType} is not exist in Skill Type");
            }
            
            return RangeSkillType[skillType].min;
        }
        
        public static int GetHashID<T>(this T enumValue) where T : Enum
        {
            if (!_skillHashID.TryGetValue(enumValue, out var value))
            {
                return -1;
            }
            return value;
        }

        public static bool ContainHashID<T>(this T enumValue, int id) where T : Enum
        {
            var type = typeof(T);
            if (!RangeSkillType.ContainsKey(type)) return false;
            var range = RangeSkillType[type];
            if (id < range.min || id >= range.amount + range.min) return false;
            return true;
        }
        
        public static bool ContainHashID(this Type type, int id)
        {
            if (!RangeSkillType.ContainsKey(type)) return false;
            var range = RangeSkillType[type];
            if (id < range.min || id >= range.amount + range.min) return false;
            return true;
        }
    }

    public enum WeaponType
    {
        PowerPole,
        SwordSkill,
        AxeSkill,
        ShieldSkill,
        TowerSkill,
        SpinerSkill,
        PowerPole2,
        FireSkill,
        IceSkill,
    }

    public enum SuppliesType
    {
        AddHP,
        UpgradeMagnet,
        SpeedShoot,
        AddDamage,
        RestoreHP,
        AddSpeed
    }
}