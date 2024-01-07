using UnityEngine;
using UnityEngine.Events;

namespace Game
{
    public class EnemyBullet : UbhBullet
    {
        [Space] [SerializeField] protected int _enemyId;
        [SerializeField] protected GameObject _bullet;
        [SerializeField] protected ParticleSystem _hitEffect;

        [Header("On Contact Event")] [SerializeField]
        protected UnityEvent _onContactEvent;

        protected bool m_isActive;

        [SerializeField] protected float _bulletDamage;
        [SerializeField] protected float _cachedSpeed;
        [SerializeField] protected float _lifeTime;

        void OnEnable()
        {
            m_useAutoRelease = true;
            m_autoReleaseTime = _lifeTime;
            m_speed = _cachedSpeed;
        }

        /// <summary>
        /// Activate/Inactivate flag
        /// Override this property when you want to change the behavior at Active / Inactive.
        /// </summary>
        public override bool isActive
        {
            get { return m_isActive; }
        }

        /// <summary>
        /// Activate/Inactivate Bullet
        /// </summary>
        public override void SetActive(bool isActive)
        {
            m_isActive = isActive;
            m_speed = _cachedSpeed;
            _bullet.SetActive(isActive);
        }

        public virtual void OnTriggerEnter2D(Collider2D other)
        {
            if (this._hitEffect)
            {
                PoolContainer.SpawnFX(this._hitEffect.transform, transform.position, GameServices.RotIdentity);
            }

            if (other.CompareTag("Player"))
            {
                PlayerManager.Instance.Combat.TakeDamage(_bulletDamage);
                _onContactEvent?.Invoke();
            }

            PoolContainer.DeSpawnBullet(this.gameObject);
        }
    }
}