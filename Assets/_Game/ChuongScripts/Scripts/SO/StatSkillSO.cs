using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Game;
using UnityEngine;

namespace Game
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
        [SerializeReference, SubclassSelector] public List<IUpgradeSkill> listUpgradeSkill = new();

        public void ApplyUpgrade<T>(T attribute) where T : IAttribute
        {
            for (int index = 0; index < listUpgradeSkill.Count; index++)
            {
                listUpgradeSkill[index].Upgrade(attribute);
            }
        }
        
        public void ApplyUpgrade<T>(params T[] attributes) where T : IAttribute
        {
            for (int attributeIndex = 0; attributeIndex < attributes.Length; attributeIndex++)
            {
                ApplyUpgrade(attributes[attributeIndex]);
            }
        }
        
        public void ApplyUpgrade<T>(List<T> attributes) where T : IAttribute
        {
            for (int attributeIndex = 0; attributeIndex < attributes.Count; attributeIndex++)
            {
                ApplyUpgrade(attributes[attributeIndex]);
            }
        }

        public void Append(List<IUpgradeSkill> listUpgrade)
        {
            listUpgradeSkill.AddRange(listUpgrade);
        }

        public void Append(SkillUpgradeInfo skillUpgradeInfo)
        {
            listUpgradeSkill.AddRange(skillUpgradeInfo.listUpgradeSkill);
        }
    }
}