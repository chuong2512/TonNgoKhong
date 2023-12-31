using System;
using System.Collections.Generic;
using SinhTon;
using UnityEngine;

namespace Skill
{
    public class HashIDSkill : PersistentSingleton<HashIDSkill>
    {
        private static readonly Type[] HashList = 
        {
            typeof(WeaponType),
            typeof(SuppliesType)
        };
        
        private readonly Dictionary<Type, int> _skillTypeAmount = new();
        private readonly Dictionary<Enum, int> _skillHashID = new();
        private readonly Dictionary<int, Enum> _skillValues = new();

        public Enum this[int hashID] => GetSkillValue(hashID);
        
        protected override void Awake()
        {
            base.Awake();
            InitData();
        }

        private void InitData()
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
        

        public void GetSkillTypeValues<T>(out T[] skills) where T : Enum
        {
            var type = typeof(T);
            if (!_skillTypeAmount.ContainsKey(type))
            {
                Debug.LogError($"{type} is not exist in Skill Type");
                skills = null;
            }
            skills = (T[])Enum.GetValues(type);
        }
        
        public int GetSKillAmount(Type skillType)
        {
            if (!_skillTypeAmount.ContainsKey(skillType))
            {
                Debug.LogError($"{skillType} is not exist in Skill Type");
            }
            
            return _skillTypeAmount[skillType];
        }

        public int GetHashID<T>(T enumValue) where T : Enum
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
        
        public Enum GetSkillValue(int hashID)
        {
            return _skillValues.ContainsKey(hashID) ? _skillValues[hashID] : null;
        }
    }


    public enum WeaponType
    {
        PowerPole1,
        PowerPole2,
        PowerPole3,
    }

    public enum SuppliesType
    {
        supplies1,
        supplies2,
        supplies3,
    }
}