using Skill;
using UnityEngine;

namespace Game
{
    public class AddDamageSupply : SupplySkill
    {
        public override void Upgrade()
        {
            
        }

        public override SuppliesType SuppliesType => SuppliesType.AddDamage;
    }
}