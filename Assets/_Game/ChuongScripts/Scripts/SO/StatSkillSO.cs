using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using Sirenix.Serialization;
using Skill;
using UnityEngine;

namespace _TonNgoKhong
{
    [CreateAssetMenu(fileName = "SkillStatSO", menuName = "ScriptableObjects/SkillStatSO", order = 1)]
    public class StatSkillSO : SerializedScriptableObject
    {
        public List<SkillUpgradeInfo> ListUpgradeSkill;

        public SkillUpgradeInfo this[int level] => GetSkillUpgradeInfo(level);
        
        public SkillUpgradeInfo GetSkillUpgradeInfo(int level)
        {
            level--; //Get level index
            if (ListUpgradeSkill == null)
            {
                return null;
            }

            if (level < 0 || level >= ListUpgradeSkill.Count)
            {
                return null;
            }

            return ListUpgradeSkill[level];
        }

        private void InitDefault()
        {
            ListUpgradeSkill = new List<SkillUpgradeInfo>(6);
        }
    }

    [Serializable]
    public class SkillUpgradeInfo
    {
        [SerializeReference, SubclassSelector] public List<IUpgradeSkill> listUpgradeSkill;

        public void ApplyUpgrade<T>(T attribute) where T : IAttribute
        {
            for (int index = 0; index < listUpgradeSkill.Count; index++)
            {
                listUpgradeSkill[index].Upgrade(attribute);
            }
        }
    }
}