using Skill;
using UnityEngine;

namespace Game
{
    public class RestoreHPSupply : SupplySkill
    {
        public override void Upgrade()
        {
        }

        public override SuppliesType SuppliesType => SuppliesType.RestoreHP;
    }
}