using Game;
using UnityEngine;

namespace Game
{
    public class AddDamageSupply : SupplySkill
    {
        [SerializeField] private ParticleSystem hp;

        public override void Upgrade()
        {
            hp.Play();
        }

        public override SuppliesType SuppliesType => SuppliesType.AddDamage;
    }
}