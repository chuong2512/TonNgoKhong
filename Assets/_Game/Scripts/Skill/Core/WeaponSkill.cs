using System.Collections.Generic;
using UnityEngine;

namespace Skill
{
    public abstract class WeaponSkill : BaseSkill, IWeaponSkill
    {
        public override int HashID => WeaponType.GetHashID();
        public abstract override void Upgrade();

        public abstract void Upgrade(List<IUpgradeSkill> list);
        public abstract WeaponType WeaponType { get; }
        public abstract void ActiveWeapon();
    }
}