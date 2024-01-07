using Skill;
using UnityEngine;

namespace Game
{
    public class RestoreHPSupply : SupplySkill
    {
        public override void Upgrade()
        {
            PlayerManager.Instance.Combat.RestoreHP();
        }

        public override SuppliesType SuppliesType => SuppliesType.RestoreHP;
    }
}