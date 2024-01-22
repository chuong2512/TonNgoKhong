using System;
using System.Collections.Generic;
using Game;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game.Weapons
{
    public class PowerPoleSkill : WeaponSkill
    {
        [FormerlySerializedAs("powerPoleController")] [SerializeField] private ShotController shotController;
        
        public override WeaponType WeaponType => WeaponType.PowerPole;
        private PowerPoleAttribute _poleAttribute = new PowerPoleAttribute();

        public override void Upgrade()
        {
            _statSkillSo[Level].ApplyUpgrade(_poleAttribute);
            shotController.Refresh();
        }

        public override void Upgrade(SkillUpgradeInfo skillUpgradeInfo)
        {
            skillUpgradeInfo.ApplyUpgrade(_poleAttribute);
            shotController.Refresh();
        }
        
        public override void Upgrade(List<IUpgradeSkill> list)
        {
            foreach (var upgradeSkill in list)
            {
                upgradeSkill.Upgrade(_poleAttribute);
            }
        }

        public override void ActiveWeapon()
        {
            shotController.enabled = true;
            _poleAttribute.MultipleAmount = 1;
            shotController.attribute = _poleAttribute;
        }
    }
}