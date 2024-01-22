using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    [CreateAssetMenu(fileName = "SkillSO", menuName = "ScriptableObjects/SkillSO", order = 1)]
    public class SkillSO : ScriptableObject
    {
        [SubclassSelector, SerializeReference] public List<SkillInfo> listSkill;

        public SkillInfo this[int hashID] => GetSkillInfo(hashID);
        
        public SkillInfo GetSkillInfo(int hashID)
        {
            return listSkill.Find(info => info.hashID == hashID);
        }

    }

    [Serializable]
    public abstract class SkillInfo
    {
        public abstract int hashID { get; }
        public Sprite icon;
        [field: SerializeField] public virtual string nameSkill { get; protected set; }
        public string contentSkill;
    }

    [Serializable]
    public class WeaponSkillInfo : SkillInfo
    {
        public WeaponType weaponType;
        public override int hashID => weaponType.GetHashID();

#if UNITY_EDITOR
        public override string nameSkill { get => weaponType.ToString();
            protected set
            {
                return;
            }
        }
#endif
    }
    
    [Serializable]
    public class SuppliesSkillInfo : SkillInfo
    {
        public SuppliesType suppliesType;
        public override int hashID => suppliesType.GetHashID();
        
#if UNITY_EDITOR
        public override string nameSkill { get => suppliesType.ToString();
            protected set
            {
                return;
            }
        }
#endif
    }
}