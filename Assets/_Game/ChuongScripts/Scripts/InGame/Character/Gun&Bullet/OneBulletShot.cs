using System.Collections;
using Game;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game
{
    public class OneBulletShot : UbhBaseShot, IPlayerShot
    {
        [Header("===== LinearShot Settings =====")]
        // "Set a angle of shot. (0 to 360)"
        [Range(0f, 360f), FormerlySerializedAs("_Angle")]
        public float m_angle = 180f;

        public float offsetAngle = 0;

        // "Transform of lock on target."
        // "It is not necessary if you want to specify target in tag."
        // "Overwrite Angle in direction of target to Transform.position."
        [FormerlySerializedAs("_TargetTransform")]
        public Transform m_targetTransform;

        // "Always aim to target."
        [FormerlySerializedAs("_Aiming")] public bool m_aiming;

        /// <summary>
        /// is lock on shot flag.
        /// </summary>

        public override bool lockOnShot
        {
            get { return true; }
        }

        public override void Shot()
        {
            if (m_shooting)
            {
                return;
            }

            AimTarget();

            ShotSingle();

            if (m_aiming)
            {
                StartCoroutine(AimingCoroutine());
            }
        }

        public void SetBulletAttribute(BulletAttribute attribute)
        {
            BulletAttribute = attribute;
        }

        public void SetTarget(Transform target)
        {
            m_targetTransform = target;
        }

        public void Init()
        {
        }

        public void SetBarrel(Transform gunBarrel)
        {
            m_Barrel = gunBarrel;
        }

        public void SetBullet(GameObject bullet)
        {
            m_bulletPrefab = bullet;
        }

        public void StopShot()
        {
        }

        public bool IsShoting()
        {
            return false;
        }

        private void ShotSingle()
        {
            if (m_bulletNum <= 0 || m_bulletSpeed <= 0f)
            {
                Debug.LogWarning("Cannot shot because BulletNum or BulletSpeed is not set.");
            }

            if (m_shooting)
            {
                return;
            }

            m_shooting = true;

            FiredShot();

            var bullet = GetBullet(transform.position);

            if (bullet == null)
            {
                return;
            }

            ShotBullet(bullet, m_bulletSpeed, m_angle + offsetAngle);

            FinishedShot();
        }

        protected override UbhBullet GetBullet(Vector3 position)
        {
            if (m_bulletPrefab == null)
            {
                Debug.LogWarning("Cannot generate a bullet because BulletPrefab is not set.");
                return null;
            }

            // get UbhBullet from ObjectPool
            PlayerBullet bullet = PoolContainer
                .SpawnBullet(m_bulletPrefab, m_Barrel.position)
                .GetComponent<PlayerBullet>();

            if (bullet == null)
            {
                return null;
            }

            bullet.BulletAttribute = BulletAttribute;

            return bullet;
        }

        protected void AimTarget()
        {
            if (m_targetTransform != null)
            {
                m_angle = UbhUtil.GetAngleFromTwoPosition(transform, m_targetTransform, m_axisMove);
            }
        }

        public void SetAngle(float angle)
        {
            m_angle = angle;
        }

        protected IEnumerator AimingCoroutine()
        {
            while (m_aiming)
            {
                if (m_shooting == false)
                {
                    yield break;
                }

                AimTarget();

                yield return null;
            }

            yield break;
        }

        public bool IsShooting()
        {
            return false;
        }

        public BulletAttribute BulletAttribute { get; set; }
    }
}