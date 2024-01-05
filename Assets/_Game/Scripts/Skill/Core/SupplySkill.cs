using UnityEngine;

namespace Skill
{
    public abstract class SupplySkill : BaseSkill, ISuppliesSkill
    {
        public override int HashID => SuppliesType.GetHashID();
        public abstract override void Upgrade();
        public abstract SuppliesType SuppliesType { get; }
    }
}