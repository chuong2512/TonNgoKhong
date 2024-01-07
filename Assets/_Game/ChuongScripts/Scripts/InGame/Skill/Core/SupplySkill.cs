using UnityEngine;

namespace Skill
{
    public abstract class SupplySkill : BaseSkill, ISuppliesSkill
    {
        public override int HashID => SuppliesType.GetHashID();

        public override void Upgrade()
        {
            return;
        }
        public void Apply<T>(T attribute) where T : IAttribute
        {
            _statSkillSo[Level].ApplyUpgrade(attribute);
        }

        public abstract SuppliesType SuppliesType { get; }
    }
}