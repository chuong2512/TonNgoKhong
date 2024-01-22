using System.Collections.Generic;
using Game;

namespace Game
{
    public abstract class WeaponSkill : BaseSkill, IWeaponSkill
    {
        public override int HashID => WeaponType.GetHashID();
        public abstract override void Upgrade();

        public abstract void Upgrade(List<IUpgradeSkill> list);
        public abstract void Upgrade(SkillUpgradeInfo skillUpgradeInfo);
        public abstract WeaponType WeaponType { get; }
        public abstract void ActiveWeapon();
    }
}