using _TonNgoKhong;
using Game;
using UnityEngine;
using UnityEngine.UI.Extensions;

namespace Skill
{
    public abstract class BaseSkill : MonoBehaviour, IInfoSkill, IUpgradable
    {
        [SerializeField] protected StatSkillSO _statSkillSo;

        [ReadOnly][SerializeField] private int TestLevel = 0;
        
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
                TestLevel = Level;
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