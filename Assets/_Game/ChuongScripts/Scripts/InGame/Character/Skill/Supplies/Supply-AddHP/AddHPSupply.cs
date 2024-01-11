using Skill;
using UnityEngine;

namespace Game
{
    public class AddHPSupply : SupplySkill
    {
        [SerializeField] private ParticleSystem hp;
        
        public override void Upgrade()
        {
            hp.Play();
            PlayerManager.Instance.Combat.Healing(0, 15);
        }

        public override SuppliesType SuppliesType => SuppliesType.AddHP;
    }
}