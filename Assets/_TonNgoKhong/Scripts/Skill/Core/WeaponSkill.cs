using UnityEngine;

namespace Skill
{
    public abstract class WeaponSkill : MonoBehaviour, IWeaponSkill
    {
        public abstract int Level { get; }
        public abstract int HashID { get; }
        public abstract WeaponType WeaponType { get; }
        public abstract void ActiveWeapon();
    }
}