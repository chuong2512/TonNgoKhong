using System.Collections.Generic;
using System.Linq;
using Game;
using SinhTon;
using Skill;
using UnityEngine;

public class PlayerManager : Singleton<PlayerManager>
{
    [SerializeField] public PlayerCombat Combat;

    [Header("Spawen Transformer")] public AudioSource EffectArrow;
    public AudioSource AudioHeat;
    public GameObject Death;
    public GameObject SpawenShoot;
    public GameObject ContainerWap;
    public Vector3 Offest;
    private Vector3 rb;

    [Header("Containers")] public GameObject Bolts;
    public GameObject UI;

    [Header("Boolean manager")] internal bool Deaths = true;

    [SerializeField] private PlayerStat _baseStat;

    private List<IUpgradeSkill> _listBuff;
    private PlayerAttribute _currentAttribute;

    public PlayerAttribute CurrentAttribute => _currentAttribute;

    void Start()
    {
        InitAttribute();

        InGameAction.OnPlayerDie += OnPlayerDie;
    }

    private void InitAttribute()
    {
        _listBuff = new List<IUpgradeSkill>();

        _currentAttribute = (PlayerAttribute) _baseStat;

        Combat.PlayerAttribute = _currentAttribute;
        Combat.InitHealth();
    }

    public void Upgrade(List<IUpgradeSkill> listSkill)
    {
        _listBuff = _listBuff.Append<>(listSkill).ToList();

        foreach (var upgradeSkill in listSkill)
        {
            upgradeSkill.Upgrade(_baseStat);
        }
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
        UI.transform.position = Vector3.SmoothDamp(transform.position, transform.position + Offest, ref rb, 0);
        SpawenShoot.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        HitBolts();
    }

    void HitBolts()
    {
        if (GameManager.Instance.AvailabelWeapon == true)
        {
            if (GameManager.Instance.SpawnObject == true)
            {
                (Instantiate(Bolts, SpawenShoot.transform.position, Quaternion.identity) as GameObject).transform
                    .SetParent(ContainerWap.transform);
                EffectArrow.Play();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(TagConstants.Enemy))
        {
            AudioHeat.Play();
            Combat.TakeDamage(0.5f - (0.5f *  CurrentAttribute.Defense) / 100);
        }
    }
}