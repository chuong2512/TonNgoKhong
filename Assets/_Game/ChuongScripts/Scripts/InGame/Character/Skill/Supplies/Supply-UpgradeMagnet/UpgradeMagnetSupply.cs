using Skill;
using UnityEngine;

namespace Game
{
    public class UpgradeMagnetSupply : SupplySkill
    {
        public override void Upgrade()
        {
        }

        public override SuppliesType SuppliesType => SuppliesType.UpgradeMagnet;
    }
}