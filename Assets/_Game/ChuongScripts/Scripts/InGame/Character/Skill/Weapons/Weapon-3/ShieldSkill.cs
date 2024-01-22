using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class ShieldSkill : WeaponSkill
{
    [SerializeField] private PlayerShield _shield;

    private ShieldAttribute _attribute = new();

    public override void Upgrade()
    {
        _statSkillSo[Level].ApplyUpgrade(_attribute);
        _shield.Refresh();
    }

    public override void Upgrade(List<IUpgradeSkill> list)
    {
        foreach (var upgradeSkill in list)
        {
            upgradeSkill.Upgrade(_attribute);
        }
    }

    public override void Upgrade(SkillUpgradeInfo skillUpgradeInfo)
    {
        skillUpgradeInfo.ApplyUpgrade(_attribute);
        _shield.Refresh();
    }

    public override WeaponType WeaponType => WeaponType.ShieldSkill;

    public override void ActiveWeapon()
    {
        _shield.enabled = true;
        _shield.attribute = _attribute;
    }
}

public class ShieldAttribute : ISpeedAttribute, IDamageAttribute, IRangeAttribute
{
    public ShieldAttribute()
    {
        Range = 1.3f;
    }

    public float Speed { get; set; }
    public float Damage { get; set; }
    public float Range { get; set; }
}