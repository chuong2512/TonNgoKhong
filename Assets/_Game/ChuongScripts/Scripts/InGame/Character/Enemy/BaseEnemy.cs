using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{

    [SelectionBase]
    public class BaseEnemy : MonoBehaviour, ICombat, IVulnerably
    {
        [SerializeField] protected ushort _id;
        public ushort Id => _id;

        [SerializeField] protected bool _isBoss;
        public bool IsBoss => _isBoss;

        [SerializeField] private float _priority;
        public float Priority => _priority;

        [SerializeField] protected EnemyAttribute attribute;

        [ChildGameObjectsOnly] [SerializeField]
        private AEnemyAnimator _animator;

        [SerializeField] private float _enemySize;

        public Transform colliderTarget;

        public float Health => attribute.Health;

        public float MaxHealth => attribute.MaxHealth;

        public void Reset()
        {
            attribute.Health = attribute.MaxHealth;
        }

        private void Start()
        {
            Reset();
        }

        public float EnemySize
        {
            get => _enemySize;
            set => _enemySize = value;
        }

        private void OnValidate()
        {
            var col = GetComponentInChildren<Collider2D>();
            if (col)
            {
                colliderTarget = col.transform;
            }
        }

        public virtual void TakeDamage(DamageInfo damageInfo)
        {
            if (attribute.Health <= 0) return;


            if (!_isBoss)
            {
                if (attribute.Health <= attribute.MaxHealth * 0.25f)
                {
                    DeadExecute();
                    return;
                }
            }
            else
            {
                if (attribute.Health <= attribute.MaxHealth * 0.1f)
                {
                    DeadExecute();
                    return;
                }
            }

            if (attribute.Health <= 0)
            {
                Die();
            }
        }

        /// <summary>
        /// Take damage by a percentage amount (0 - 100)
        /// </summary>
        public void TakeDamageByHealthPercent(float healthPercent)
        {
            float damage = attribute.MaxHealth * healthPercent / 100f;
            if (damage > 0f)
            {
                TakeDamage(new DamageInfo(0, healthPercent));
            }
        }

        public void TakeDamage(float trueDamage)
        {
            TakeDamage(new DamageInfo(trueDamage, 0));
        }

        private void DeadExecute()
        {
            float trueDamage = attribute.MaxHealth;
            attribute.MinusHealth(trueDamage * 2f);
            Die();
        }

        public virtual void Die()
        {
            if (_animator != null)
            {
                _animator.Active(true);
                _animator.SetDead(true);
            }
        }

        public void Pause()
        {
            if (!_isBoss && !IsDestroyed())
            {
                if (_animator != null)
                {
                    _animator.Active(false);
                }
            }
        }

        public void Resume()
        {
            if (!_isBoss)
            {
                if (_animator != null)
                {
                    _animator.Active(true);
                }
            }
        }

        public bool IsDestroyed()
        {
            return attribute.Health <= 0f;
        }

        public void TakeHeal(HealInfo healInfo)
        {
            Healing(healInfo);
        }

        public void Healing(HealInfo healInfo)
        {
            attribute.Healing(healInfo);
        }


#if UNITY_EDITOR
        private void OnDrawGizmosSelected()
        {
            Gizmos.DrawWireSphere(colliderTarget.position, _enemySize);
        }
#endif
    }
}