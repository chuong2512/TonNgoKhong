using System.Collections;
using System.Collections.Generic;
using Game;
using Game.Weapons;
using UnityEngine;

public class AxeSkill : WeaponSkill
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
        _shotAttribute.MultipleAmount = 1;
        shotController.attribute = _shotAttribute;
    }

    public override WeaponType WeaponType => WeaponType.AxeSkill;
}
