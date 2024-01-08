using System.Collections;
using System.Collections.Generic;
using _TonNgoKhong;
using Skill;
using Skill.Weapons;
using UnityEngine;
using UnityEngine.Serialization;

public class SwordSkill : WeaponSkill
{
    [SerializeField] private ShotController shotController;

    private SwordAttribute _shotAttribute = new();

    public override void Upgrade()
    {
        _statSkillSo[Level].ApplyUpgrade(_shotAttribute);
        shotController.Refresh();
    }

    public override void Upgrade(SkillUpgradeInfo skillUpgradeInfo)
    {
        skillUpgradeInfo.ApplyUpgrade(_shotAttribute);
        shotController.Refresh();
    }

    public override void Upgrade(List<IUpgradeSkill> list)
    {
        foreach (var upgradeSkill in list)
        {
            upgradeSkill.Upgrade(_shotAttribute);
        }
    }

    public override void ActiveWeapon()
    {
        shotController.enabled = true;
        _shotAttribute.MultipleAmount = 2;
        shotController.attribute = _shotAttribute;
    }

    public override WeaponType WeaponType => WeaponType.SwordSkill;
}