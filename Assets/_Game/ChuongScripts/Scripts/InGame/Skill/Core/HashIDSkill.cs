using System;
using System.Collections.Generic;
using SinhTon;
using UnityEngine;

namespace Skill
{
    public static class HashIDSkill
    {
        private static readonly Type[] HashList = 
        {
            typeof(WeaponType),
            typeof(SuppliesType)
        };
        
        private static readonly Dictionary<Type, int> _skillTypeAmount = new();
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
                _skillTypeAmount[type] = amount;
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
            if (!_skillTypeAmount.ContainsKey(type))
            {
                Debug.LogError($"{type} is not exist in Skill Type");
                skills = null;
            }
            skills = (T[])Enum.GetValues(type);
        }
        
        public static int GetSkillAmount(Type skillType)
        {
            if (!_skillTypeAmount.ContainsKey(skillType))
            {
                Debug.LogError($"{skillType} is not exist in Skill Type");
            }
            
            return _skillTypeAmount[skillType];
        }
        
        public static int GetHashID<T>(this T enumValue) where T : Enum
        {
#if UNITY_EDITOR
            if (!_skillTypeAmount.ContainsKey(typeof(T)))
            {
                Debug.LogError($"{typeof(T)} is not exist in Skill Type");
                return -1;
            }
#endif
            return _skillHashID[enumValue];
        }
        
    }

    public enum WeaponType
    {
        PowerPole,
        PowerPole2,
        PowerPole3,
    }

    public enum SuppliesType
    {
        Supplies1,
        Supplies2,
        Supplies3,
    }
}