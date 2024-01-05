using System;
using _TonNgoKhong;
using Game;
using SinhTon;
using UnityEngine;

namespace Skill
{
    public abstract class BaseSkill : MonoBehaviour, IInfoSkill, IUpgradable
    {
        [SerializeField] protected StatSkillSO _statSkillSo;
        
        private void Awake()
        {
            InGameAction.OnUpgradeSkill += UpgradeSkill;
        }

        private void UpgradeSkill(int hashID)
        {
            if (hashID != HashID) return;

            if (!SkillSelector.Instance.IsMaxLevel(hashID))
            {
                Upgrade();
            }
        }

        private void OnDestroy()
        {
            InGameAction.OnUpgradeSkill -= UpgradeSkill;
        }

        public int Level => SkillSelector.Instance.GetSkillLevel(HashID);
        public abstract int HashID { get; }
        public abstract void Upgrade();
    }
}