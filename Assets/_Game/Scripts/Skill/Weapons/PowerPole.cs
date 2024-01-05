using System.Collections.Generic;
using _TonNgoKhong;
using UnityEngine;

namespace Skill.Weapons
{
    public class PowerPole : WeaponSkill
    {
        public override WeaponType WeaponType => WeaponType.PowerPole;
        private PowerPoleAttribute _poleAttribute = new();

        public override void Upgrade()
        {
        }

        public override void Upgrade(List<IUpgradeSkill> list)
        {
        }

        public override void ActiveWeapon()
        {
        }
    }
}