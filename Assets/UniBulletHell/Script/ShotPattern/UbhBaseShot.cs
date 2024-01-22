using Game;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

/// <summary>
/// Ubh base shot.
/// Each shot pattern classes inherit this class.
/// </summary>
public abstract class UbhBaseShot : UbhMonoBehaviour
{
    [Header("===== Common Settings =====")]
    // "Set a bullet prefab for the shot. (ex. sprite or model)"
    [FormerlySerializedAs("_BulletPrefab")]
    public GameObject m_bulletPrefab;

    // "Set a bullet number of shot."
    [FormerlySerializedAs("_BulletNum")] public int m_bulletNum = 10;

    // "Set a bullet base speed of shot."
    [FormerlySerializedAs("_BulletSpeed")] public float m_bulletSpeed = 2f;

    // "Set an acceleration of bullet speed."
    [FormerlySerializedAs("_AccelerationSpeed")]
    public float m_accelerationSpeed = 0f;

    // "Use max speed flag."
    public bool m_useMaxSpeed = false;

    // "Set max speed."
    [UbhConditionalHide("m_useMaxSpeed")] public float m_maxSpeed = 0f;

    // "Use min speed flag"
    public bool m_useMinSpeed = false;

    // "Set min speed."
    [UbhConditionalHide("m_useMinSpeed")] public float m_minSpeed = 0f;

    // "Set an acceleration of bullet turning."
    [FormerlySerializedAs("_AccelerationTurn")]
    public float m_accelerationTurn = 0f;

    // "This flag is pause and resume bullet at specified time."
    [FormerlySerializedAs("_UsePauseAndResume")]
    public bool m_usePauseAndResume = false;

    // "Set a time to pause bullet."
    [FormerlySerializedAs("_PauseTime"), UbhConditionalHide("m_usePauseAndResume")]
    public float m_pauseTime = 0f;

    // "Set a time to resume bullet."
    [FormerlySerializedAs("_ResumeTime"), UbhConditionalHide("m_usePauseAndResume")]
    public float m_resumeTime = 0f;

    // "This flag is automatically release the bullet GameObject at the specified time."
    [FormerlySerializedAs("_UseAutoRelease")]
    public bool m_useAutoRelease = false;

    // "Set a time to automatically release after the shot at using UseAutoRelease. (sec)"
    // [FormerlySerializedAs("_AutoReleaseTime"), UbhConditionalHide("m_useAutoRelease")]
    private float m_autoReleaseTime = 10f;

    [FormerlySerializedAs("_AutoReleaseRange"), UbhConditionalHide("m_useAutoRelease")]
    public float m_autoReleaseRange = 12f;

    [Space(10)] [Header("===== 3DX Setting =====")]
    public UbhUtil.AXIS m_axisMove = UbhUtil.AXIS.X_AND_Y;

    public bool m_inheritAngle = false;

    [Space(10)] [Header("===== 3DX Extend =====")]
    private int trueDamage;

    public Transform m_Barrel;

    // "Set a callback method fired shot."
    public UnityEvent m_shotFiredCallbackEvents = new UnityEvent();

    // "Set a callback method after shot."
    public UnityEvent m_shotFinishedCallbackEvents = new UnityEvent();

    protected bool m_shooting;

    private UbhShotCtrl m_shotCtrl;

    protected virtual void Start()
    {
        m_autoReleaseTime = m_autoReleaseRange / m_bulletSpeed;
    }

    public UbhShotCtrl shotCtrl
    {
        get
        {
            if (m_shotCtrl == null)
            {
                m_shotCtrl = transform.GetComponentInParent<UbhShotCtrl>();
            }

            return m_shotCtrl;
        }
    }

    /// <summary>
    /// is shooting flag.
    /// </summary>
    public bool shooting
    {
        get { return m_shooting; }
    }

    /// <summary>
    /// is lock on shot flag.
    /// </summary>
    public virtual bool lockOnShot
    {
        get { return false; }
    }

    /// <summary>
    /// Call from override OnDisable method in inheriting classes.
    /// Example : protected override void OnDisable () { base.OnDisable (); }
    /// </summary>
    protected virtual void OnDisable()
    {
        m_shooting = false;
    }

    /// <summary>
    /// Abstract shot method.
    /// </summary>
    public abstract void Shot();

    /// <summary>
    /// UbhShotCtrl setter.
    /// </summary>
    public void SetShotCtrl(UbhShotCtrl shotCtrl)
    {
        m_shotCtrl = shotCtrl;
    }

    /// <summary>
    /// Fired shot.
    /// </summary>
    protected void FiredShot()
    {
        m_shotFiredCallbackEvents.Invoke();
    }

    /// <summary>
    /// Finished shot.
    /// </summary>
    public virtual void FinishedShot()
    {
        m_shooting = false;
        m_shotFinishedCallbackEvents.Invoke();
    }

    public bool IsShooting()
    {
        return m_shooting;
    }

    /// <summary>
    /// Get UbhBullet object from object pool.
    /// </summary>
    protected virtual UbhBullet GetBullet(Vector3 position)
    {
        if (m_bulletPrefab == null)
        {
            Debug.LogWarning("Cannot generate a bullet because BulletPrefab is not set.");
            return null;
        }

        // get UbhBullet from ObjectPool
        UbhBullet bullet = PoolContainer
            .SpawnBullet(m_bulletPrefab, m_Barrel.position);
        if (bullet == null)
        {
            return null;
        }

        return bullet;
    }

    protected UbhBullet SpawnBulletAt(Vector3 position)
    {
        if (m_bulletPrefab == null)
        {
            Debug.LogWarning("Cannot generate a bullet because BulletPrefab is not set.");
            return null;
        }

        // get UbhBullet from ObjectPool
        UbhBullet bullet = PoolContainer.SpawnBullet(m_bulletPrefab, position)
            .GetComponent<UbhBullet>();
        if (bullet == null)
        {
            return null;
        }

        return bullet;
    }

    /// <summary>
    /// Shot UbhBullet object.
    /// </summary>
    protected virtual void ShotBullet(UbhBullet bullet, float speed, float angle,
        bool homing = false, Transform homingTarget = null, float homingAngleSpeed = 0f,
        bool wave = false, float waveSpeed = 0f, float waveRangeSize = 0f)
    {
        if (bullet == null)
        {
            return;
        }

        bullet.Shot(this,
            speed, angle, m_accelerationSpeed, m_accelerationTurn,
            homing, homingTarget, homingAngleSpeed,
            wave, waveSpeed, waveRangeSize,
            m_usePauseAndResume, m_pauseTime, m_resumeTime,
            m_useAutoRelease, m_autoReleaseTime,
            m_axisMove, m_inheritAngle,
            m_useMaxSpeed, m_maxSpeed, m_useMinSpeed, m_minSpeed);
    }

    protected virtual void ShotBullet(UbhBullet bullet, float speed, float angle,
        bool homing, Transform homingTarget, float homingAngleSpeed,
        bool wave, float waveSpeed, float waveRangeSize, bool mWaveInverse)
    {
        if (bullet == null)
        {
            return;
        }

        bullet.Shot(this, speed, angle, m_accelerationSpeed, m_accelerationTurn,
            homing, homingTarget, homingAngleSpeed,
            wave, waveSpeed, waveRangeSize,
            m_usePauseAndResume, m_pauseTime, m_resumeTime,
            m_useAutoRelease, m_autoReleaseTime,
            m_axisMove, m_inheritAngle,
            m_useMaxSpeed, m_maxSpeed, m_useMinSpeed, m_minSpeed);
    }
}