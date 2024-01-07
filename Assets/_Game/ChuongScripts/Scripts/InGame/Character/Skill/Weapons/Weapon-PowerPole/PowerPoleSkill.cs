using System;
using System.Collections.Generic;
using _TonNgoKhong;
using UnityEngine;
using UnityEngine.Serialization;

namespace Skill.Weapons
{
    public class PowerPoleSkill : WeaponSkill
    {
        [SerializeField] private PowerPoleController powerPoleController;
        
        public override WeaponType WeaponType => WeaponType.PowerPole;
        private PowerPoleAttribute _poleAttribute = new PowerPoleAttribute();

        public override void Upgrade()
        {
            foreach (var upgradeSkill in _statSkillSo.GetSkillUpgradeInfo(Level).listUpgradeSkill)
            {
                upgradeSkill.Upgrade(_poleAttribute);
            }

            powerPoleController.Refresh();
        }

        public override void Upgrade(SkillUpgradeInfo skillUpgradeInfo)
        {
            skillUpgradeInfo.ApplyUpgrade(_poleAttribute);
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
            powerPoleController.enabled = true;
            _poleAttribute.MultipleAmount = 1;
            powerPoleController.attribute = _poleAttribute;
        }
    }
}