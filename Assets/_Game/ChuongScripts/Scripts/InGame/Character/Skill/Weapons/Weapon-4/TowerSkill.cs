using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class TowerSkill : WeaponSkill
{
    [SerializeField] private TowerController _tower;

    private TowerAttribute _attribute = new TowerAttribute();

    public override void Upgrade()
    {
        _statSkillSo[Level].ApplyUpgrade(_attribute);
        _tower.Refresh();
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
        _tower.Refresh();
    }

    public override WeaponType WeaponType => WeaponType.TowerSkill;

    public override void ActiveWeapon()
    {
        _tower.enabled = true;
        _tower.attribute = _attribute;
    }
}