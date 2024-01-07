using System.Collections.Generic;
using _TonNgoKhong;
using Game;
using SinhTon;
using Skill;
using Skill.Weapons;
using UnityEngine;

public class PlayerManager : Singleton<PlayerManager>
{
    [SerializeField] public PlayerCombat Combat;
    
    public Dictionary<int, WeaponSkill> WeaponSkills;
    public Dictionary<int, SupplySkill> SupplySkills;
    public AudioSource AudioHeat;
    public GameObject Death;
    public GameObject SpawenShoot;

    [Header("Boolean manager")] internal bool Deaths = true;

    [SerializeField] private PlayerStat _baseStat;

    private SkillUpgradeInfo _listBuff;
    private PlayerAttribute _currentAttribute;
    private Dictionary<int, BaseSkill> _skillDict;

    public PlayerAttribute CurrentAttribute => _currentAttribute;

    void Start()
    {
        InitAttribute();

        InGameAction.OnPlayerDie += OnPlayerDie;
    }

    private void InitAttribute()
    {
        _listBuff = new SkillUpgradeInfo();

        _currentAttribute = (PlayerAttribute) _baseStat;

        Combat.PlayerAttribute = _currentAttribute;
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
            Combat.TakeDamage(0.5f - (0.5f * CurrentAttribute.Defense) / 100);
        }
    }

    public void UpgradeWeaponSkill(int hashIDSkill)
    {
        if (!WeaponSkills.ContainsKey(hashIDSkill))
        {
            
        }
        WeaponSkills[hashIDSkill].Upgrade();
    }

    private void InitWeaponSkill(int hashIDSkill)
    {
        WeaponSkills[hashIDSkill] = new PowerPoleSkill();
        WeaponSkills[hashIDSkill].Upgrade(_listBuff);
    }
    
    public void UpgradeSuppliesSkill(int hashIDSkill)
    {
        if (SupplySkills.ContainsKey(hashIDSkill))
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
        SupplySkills[hashIDSkill] = new AddDamageSupply();
    }
    
}