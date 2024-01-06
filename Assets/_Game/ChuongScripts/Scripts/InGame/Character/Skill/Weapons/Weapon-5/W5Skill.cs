using System.Collections;
using System.Collections.Generic;
using Skill;
using UnityEngine;

public class W5Skill : WeaponSkill
{
    public override void Upgrade()
    {
    }

    public override void Upgrade(List<IUpgradeSkill> list)
    {
    }

    public override WeaponType WeaponType => WeaponType.W5Skill;

    public override void ActiveWeapon()
    {
    }
}