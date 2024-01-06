using Skill;
using UnityEngine;

namespace Game
{
    public class AddHPSupply : SupplySkill
    {
        public override void Upgrade()
        {
            
        }

        public override SuppliesType SuppliesType => SuppliesType.AddHP;
    }
}