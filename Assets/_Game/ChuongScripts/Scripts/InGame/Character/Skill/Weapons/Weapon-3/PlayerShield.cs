using System.Collections.Generic;
using Game;
using Sirenix.OdinInspector;
using UnityEngine;

public class PlayerShield : BaseSkillController<ShieldAttribute>
{
    [SerializeField] private float _baseDmg = 1;
    [SerializeField] private float time = 1;

    public PlayerShield()
    {
        attribute = new ShieldAttribute();
    }

    private float _timeCounter;
    [ReadOnly] [SerializeField] private List<BaseEnemy> _enemies = new List<BaseEnemy>();

    public float Damage => (_baseDmg + attribute.Damage + PlayerManager.Instance.Combat.Damage);
    public float TimeTakeDMG => time - attribute.Speed;

    public override void Refresh()
    {
        transform.localScale = Vector3.one * attribute.Range;
    }

    private void FixedUpdate()
    {
        _timeCounter += Time.fixedDeltaTime;

        if (_timeCounter > TimeTakeDMG)
        {
            _timeCounter = 0;
            TakeDamage();
        }
    }

    private void TakeDamage()
    {
        if (_enemies == null || _enemies.Count == 0)
        {
            return;
        }

        _enemies.RemoveAll(enemy => enemy is null || enemy.IsDestroyed());
        var damageInfo = new DamageInfo(Damage, 0);

        for (int i = 0; i < _enemies.Count; i++)
        {
            _enemies[i].TakeDamage(damageInfo);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        var enemy = col.transform.GetComponent<BaseEnemy>();

        if (enemy && !_enemies.Contains(enemy))
        {
            _enemies.Add(enemy);
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        var enemy = col.transform.GetComponent<BaseEnemy>();

        if (enemy && _enemies.Contains(enemy))
        {
            _enemies.Remove(enemy);
        }
    }
}