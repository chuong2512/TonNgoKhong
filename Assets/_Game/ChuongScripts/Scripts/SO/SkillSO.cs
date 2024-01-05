using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
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

        [Button]
        public void SetID()
        {
            for (int i = 0; i < listSkill.Count; i++)
            {
                listSkill[i].hashID = i;
            }
        }
    }

    [Serializable]
    public class SkillInfo
    {
        public int hashID;
        public Sprite icon;
        public string nameSkill;
        public string contentSkill;
        public StatSkillSO StatSkillSo;
    }
}