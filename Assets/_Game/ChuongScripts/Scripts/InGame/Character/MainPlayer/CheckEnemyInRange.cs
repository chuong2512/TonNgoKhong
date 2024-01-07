using System;
using System.Collections.Generic;
using System.Linq;
using SinhTon;
using UnityEngine;
using UnityEngine.UI.Extensions;

namespace Game
{
    [RequireComponent(typeof(CircleCollider2D))]
    public class CheckEnemyInRange : Singleton<CheckEnemyInRange>
    {
        [ReadOnly] [SerializeField] private List<BaseEnemy> _enemies = new List<BaseEnemy>();

        public List<BaseEnemy> GetAllEnemiesInRange()
        {
            if (_enemies == null || _enemies.Count == 0)
            {
                return new List<BaseEnemy>();
            }

            var count = _enemies.Count;

            _enemies.RemoveAll(enemy => enemy is null || enemy.IsDestroyed());

            _enemies = _enemies.OrderByDescending(e => e.Priority + DistancePriotiry(e)).ToList();

            return _enemies;
        }

        private float DistancePriotiry(BaseEnemy e)
        {
            var dir = e.colliderTarget.position - transform.position;
            var distance = Vector2.SqrMagnitude(dir);

            return Mathf.Clamp(1.5f / distance, 0, 6f);
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
}