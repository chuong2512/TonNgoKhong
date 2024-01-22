using Game;
using UnityEngine;
using UnityEngine.UI.Extensions;

namespace Game
{
    public abstract class BaseSkill : MonoBehaviour, IInfoSkill, IUpgradable
    {
        [SerializeField] protected StatSkillSO _statSkillSo;

        [ReadOnly][SerializeField] private int TestLevel = 0;

        private void UpgradeSkill() 
        {
            if (SkillSelector.Instance.IsMaxLevel(HashID)) return;
            
            Upgrade();
            TestLevel = Level;
        }

        public int Level => SkillSelector.Instance.GetSkillLevel(HashID);
        public abstract int HashID { get; }
        public abstract void Upgrade();
    }
}