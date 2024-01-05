using System;
using System.Collections.Generic;
using Skill;
using UnityEngine;

namespace _TonNgoKhong
{
    [CreateAssetMenu(fileName = "SkillStatSO", menuName = "ScriptableObjects/SkillSO", order = 1)]
    public class StatSkillSO : MonoBehaviour
    {
        
    }
    
        
    [Serializable]
    public class SkillUpgradeInfo
    {
        public List<List<IUpgradeSkill>> listUpgradeSkill;
    }
}