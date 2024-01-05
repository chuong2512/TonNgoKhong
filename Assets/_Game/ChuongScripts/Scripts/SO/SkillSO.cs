using System;
using System.Collections.Generic;
using Skill;
using UnityEngine;

namespace _TonNgoKhong
{
    [CreateAssetMenu(fileName = "SkillSO", menuName = "ScriptableObjects/SkillSO", order = 1)]
    public class SkillSO : ScriptableObject
    {
        public List<SkillInfo> listSkill;

        public SkillInfo GetSkillInfo(int hashID)
        {
            return listSkill.Find(info => info.hashID == hashID);
        }
    }

    [Serializable]
    public class SkillInfo
    {
        public int hashID;
        public Sprite icon;
        public string contentSkill;
        public StatSkillSO StatSkillSo;
    }
}