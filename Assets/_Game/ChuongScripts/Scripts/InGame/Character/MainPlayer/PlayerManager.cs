using System.Collections.Generic;
using Game;
using SinhTon;
using Skill;
using UnityEngine;

public class PlayerManager : Singleton<PlayerManager>
{
    [SerializeField] public PlayerCombat Combat;
    [SerializeField] public PlayerController Controller;

    public AudioSource AudioHeat;
    public GameObject Death;
    public GameObject SpawenShoot;

    [Header("Boolean manager")] internal bool Deaths = true;

    [SerializeField] private PlayerStat _baseStat;

    private List<IUpgradeSkill> _listBuff;
    private PlayerAttribute _currentAttribute;

    public PlayerAttribute CurrentAttribute => _currentAttribute;

    public Transform Transform => Controller.transform;
    
    void Start()
    {
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
        _listBuff = new List<IUpgradeSkill>();

        _currentAttribute = (PlayerAttribute) _baseStat;

        Combat.PlayerAttribute = _currentAttribute;
        Combat.InitHealth();
    }

    public void Upgrade(List<IUpgradeSkill> listSkill)
    {
        _listBuff.AddRange(listSkill);

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
}