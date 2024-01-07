using System.Collections.Generic;
using _Game;
using _TonNgoKhong;
using Game;
using SinhTon;
using Skill;
using Skill.Weapons;
using UnityEngine;

[DefaultExecutionOrder(-99)]
public class PlayerManager : Singleton<PlayerManager>
{
    [SerializeField] public PlayerCombat Combat;
    [SerializeField] public PlayerController Controller;
    [SerializeField] private WeaponSkillContainer weaponSkillContainer;
    [SerializeField] private SuppliesSkillContainer suppliesSkillContainer;
    private Dictionary<int, WeaponSkill> WeaponSkills = new();
    private Dictionary<int, SupplySkill> SupplySkills = new();
    public AudioSource AudioHeat;
    public GameObject Death;
    public GameObject SpawenShoot;

    [Header("Boolean manager")] internal bool Deaths = true;

    [SerializeField] private PlayerStatus _baseStat;

    private SkillUpgradeInfo _listBuff;
    private PlayerStatus _currentStatus;
    private Dictionary<int, BaseSkill> _skillDict;

    public PlayerStatus CurrentStatus => _currentStatus;
    
    public Transform Transform => Controller.transform;

    protected override void Awake()
    {
        base.Awake();
        InitAttribute();
        InGameAction.OnPlayerDie += OnPlayerDie;
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

        _currentStatus =  _baseStat;

        Combat.PlayerStatus = _currentStatus;
        Combat.InitHealth();
    }

    private void OnPlayerDie()
    {
        Death.SetActive(true);
    }

    private void OnDestroy()
    {
        InGameAction.OnPlayerDie -= OnPlayerDie;
    }

    void Update()
    {
        SpawenShoot.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(TagConstants.Enemy))
        {
            AudioHeat.Play();
            Combat.TakeDamage(0.5f - (0.5f * CurrentStatus.Defense) / 100);
        }
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
        supplies.Upgrade();
        _listBuff.Append(supplies.SkillUpgradeInfo);
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