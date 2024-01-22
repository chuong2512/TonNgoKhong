using Game;
using UnityEngine;

namespace Game
{
    public class AddHPSupply : SupplySkill
    {
        [SerializeField] private ParticleSystem hp;
        
        public override void Upgrade()
        {
            hp.Play();
            PlayerManager.Instance.Combat.Healing(0, 25);
        }

        public override SuppliesType SuppliesType => SuppliesType.AddHP;
    }
}