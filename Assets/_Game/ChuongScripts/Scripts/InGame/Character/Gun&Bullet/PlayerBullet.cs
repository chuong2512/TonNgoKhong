using Game;

namespace Game
{
    using UnityEngine;
    using Sirenix.OdinInspector;

    public class PlayerBullet : UbhBullet
    {
        [SerializeField] protected GameObject _visual;
        [SerializeField] protected bool _isPiercing;

        [AssetSelector(Paths = @"Assets//0_Game/FX/Prefabs")] [SerializeField]
        protected ParticleSystem _hitEffect;

        private bool m_isActive;
        private BulletAttribute _bulletAttribute;

        public BulletAttribute BulletAttribute
        {
            get => _bulletAttribute;
            set
            {
                _bulletAttribute = value;
                m_autoReleaseTime = _bulletAttribute.LifeTime;
                m_speed = _bulletAttribute.Speed;
            }
        }

        /// <summary>
        /// Activate/Inactivate flag
        /// Override this property when you want to change the behavior at Active / Inactive.
        /// </summary>
        public override bool isActive => m_isActive;

        void OnEnable()
        {
            m_useAutoRelease = true;
        }

        /// <summary>
        /// Activate/Inactivate Bullet
        /// </summary>
        public override void SetActive(bool active)
        {
            m_isActive = active;
            _visual.SetActive(active);
        }

        protected virtual void OnTriggerEnter2D(Collider2D other)
        {
            if (this._hitEffect)
            {
                var basePosition = transform.position;
                float otherZ = other.transform.position.z;
                if (basePosition.z > otherZ)
                {
                    basePosition.z = otherZ - 0.05f;
                }

                PoolContainer.SpawnFX(this._hitEffect.transform, basePosition, GameServices.RotIdentity);
            }

            var combat = other.GetComponentInParent<BaseEnemy>();
            if (combat != null && !combat.IsDestroyed())
            {
                var damageInfo = new DamageInfo(BulletAttribute.Damage, 0);

                combat.TakeDamage(damageInfo);

                if (!_isPiercing)
                {
                    PoolContainer.DeSpawnBullet(transform);
                }
            }
        }
    }

    public class BulletAttribute : ISpeedAttribute, ILifeTimeAttribute, IDamageAttribute
    {
        public float Speed { get; set; }
        public float LifeTime { get; set; }
        public float Damage { get; set; }
    }
}