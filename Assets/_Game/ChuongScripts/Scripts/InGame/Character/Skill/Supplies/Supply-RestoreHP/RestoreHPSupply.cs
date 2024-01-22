using Game;
using UnityEngine;

namespace Game
{
    public class RestoreHPSupply : SupplySkill
    {
        [SerializeField] private ParticleSystem hp;

        public override void Upgrade()
        {
            hp.Play();
            PlayerManager.Instance.Combat.RestoreHP();
        }

        public override SuppliesType SuppliesType => SuppliesType.RestoreHP;
    }
}