using Game;
using UnityEngine;

namespace Game
{
    public class UpgradeMagnetSupply : SupplySkill
    {
        [SerializeField] private MagnetCollider _magnetCollider;

        public override void Upgrade()
        {
            _magnetCollider.RefreshCollider();
        }

        public override SuppliesType SuppliesType => SuppliesType.UpgradeMagnet;
    }
}