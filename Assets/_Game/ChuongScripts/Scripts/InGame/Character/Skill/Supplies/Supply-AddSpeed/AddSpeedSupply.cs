using Game;
using UnityEngine;

namespace Game
{
    public class AddSpeedSupply : SupplySkill
    {
        public override void Upgrade()
        {
            
        }

        public override SuppliesType SuppliesType => SuppliesType.AddSpeed;
    }
}