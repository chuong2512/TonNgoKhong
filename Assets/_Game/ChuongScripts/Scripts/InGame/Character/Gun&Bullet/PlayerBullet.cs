using Skill;

namespace Game
{
    using UnityEngine;
    using Sirenix.OdinInspector;

    public class PlayerBullet : UbhBullet
    {
        [SerializeField] protected GameObject _visual;

        [AssetSelector(Paths = @"Assets//0_Game/FX/Prefabs")] [SerializeField]
        protected ParticleSystem _hitEffect;

        [Space] [SerializeField] protected float _damageMultiply = 1.0f;
        [SerializeField] protected bool _piercing;

        protected bool m_isActive;
        protected Vector3 _originScale;
        protected float _delayCounter;

        public BulletAttribute BulletAttribute { get; set; }

        /// <summary>
        /// Activate/Inactivate flag
        /// Override this property when you want to change the behavior at Active / Inactive.
        /// </summary>
        public override bool isActive => m_isActive;

        protected virtual void OnEnable()
        {
            _originScale = transform.localScale;
            m_useAutoRelease = true;
            m_autoReleaseTime = BulletAttribute.LifeTime;
            m_speed = BulletAttribute.Speed;
            _delayCounter = 0;
        }

        /// <summary>
        /// Activate/Inactivate Bullet
        /// </summary>
        public override void SetActive(bool active)
        {
            m_isActive = active;
            _visual.SetActive(active);
        }

        protected virtual void FixedUpdate()
        {
            DelayCalculator();
        }

        private void DelayCalculator()
        {
            _delayCounter += Time.fixedDeltaTime;
        }

        protected virtual void SpawnSplitBullet()
        {
            
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

            var combat = other.GetComponentInParent<ICombat>();
            if (combat != null && !combat.IsDestroyed())
            {
                var damageInfo = new DamageInfo(BulletAttribute.Damage, 0);

                combat.TakeDamage(damageInfo);
            }

            if (other.gameObject.layer == 1 << 10 || !_piercing)
            {
                PoolContainer.DeSpawnItem(transform);
            }
        }

        protected static T GetSplitBullet<T>(GameObject bulletToSpawn, Vector3 position) where T : Component
        {
            if (bulletToSpawn == null)
            {
                Debug.LogWarning($"Cannot generate {bulletToSpawn.name}  because prefab is not set.----------");
                return null;
            }

            var bullet = PoolContainer.SpawnItem(bulletToSpawn.transform, position, GameServices.RotIdentity);
            return bullet == null ? null : bullet.GetComponent<T>();
        }
    }

    public class BulletAttribute : ISpeedAttribute, ILifeTimeAttribute, IDamageAttribute
    {
        public float Speed { get; set; }
        public float LifeTime { get; set; }
        public float Damage { get; set; }
    }
}