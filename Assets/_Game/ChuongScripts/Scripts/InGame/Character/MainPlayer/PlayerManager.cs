using System.Collections.Generic;
using Game;
using SinhTon;
using UnityEngine;

[DefaultExecutionOrder(-99)]
public class PlayerManager : Singleton<PlayerManager>
{
    [SerializeField] public PlayerCombat Combat;
    [SerializeField] public JoystickManager Controller;

    [SerializeField] private WeaponSkillContainer weaponSkillContainer;
    [SerializeField] private SuppliesSkillContainer suppliesSkillContainer;

    private Dictionary<int, WeaponSkill> WeaponSkills = new();
    private Dictionary<int, SupplySkill> SupplySkills = new();

    private SkillUpgradeInfo _listBuff;
    private PlayerStatus _currentStatus;
    private Dictionary<int, BaseSkill> _skillDict;

    public PlayerStatus CurrentStatus => _currentStatus;

    public Transform PlayerTransform => Controller.transform;

    protected override void Awake()
    {
        base.Awake();
        InitAttribute();
    }

    public void Stop()
    {
        Controller.SetSimulated(false);
    }

    public void Play()
    {
        Controller.SetSimulated(true);
    }

    private void InitAttribute()
    {
        _listBuff = new SkillUpgradeInfo();

        _currentStatus = GameManager.Instance.GetPlayerStatus();

        Combat.PlayerStatus = _currentStatus;
        Combat.InitHealth();
    }

    public void UpgradeWeaponSkill(int hashIDSkill)
    {
        if (!WeaponSkills.ContainsKey(hashIDSkill))
        {
            InitWeaponSkill(hashIDSkill);
        }

        WeaponSkills[hashIDSkill].Upgrade();
    }

    private void InitWeaponSkill(int hashIDSkill)
    {
        WeaponSkills[hashIDSkill] = weaponSkillContainer.GetSkill(hashIDSkill);
        WeaponSkills[hashIDSkill].ActiveWeapon();
        WeaponSkills[hashIDSkill].Upgrade(_listBuff);
    }

    public void UpgradeSuppliesSkill(int hashIDSkill)
    {
        if (!SupplySkills.ContainsKey(hashIDSkill))
        {
            InitSuppliesSkill(hashIDSkill);
        }

        var supplies = SupplySkills[hashIDSkill];

        _listBuff.Append(supplies.SkillUpgradeInfo);
        supplies.Apply(_currentStatus);
        supplies.Upgrade();

        foreach (var weaponSkill in WeaponSkills)
        {
            supplies.UpgradeWeapon(weaponSkill.Value);
        }
    }

    private void InitSuppliesSkill(int hashIDSkill)
    {
        SupplySkills[hashIDSkill] = suppliesSkillContainer.GetSkill(hashIDSkill);
    }
}