using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class SpinerSkill : WeaponSkill
{
    [SerializeField] private GameObject[] spiners;

    private SpinerAttribute _attribute = new();

    public override void Upgrade()
    {
        _statSkillSo[Level].ApplyUpgrade(_attribute);
        Refresh();
    }

    private void Refresh()
    {
        for (int i = 0; i < spiners.Length; i++)
        {
            spiners[i].SetActive(i < _attribute.Amount);
        }
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
        Refresh();
    }

    public override WeaponType WeaponType => WeaponType.SpinerSkill;

    public override void ActiveWeapon()
    {
    }
}

public class SpinerAttribute : IAmountAttribute, IDamageAttribute
{
    public SpinerAttribute()
    {
        Amount = 1;
    }

    public int Amount { get; set; }
    public float Damage { get; set; }
}