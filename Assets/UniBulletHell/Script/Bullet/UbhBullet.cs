using Game;
using UnityEngine;

/// <summary>
/// Ubh bullet.
/// </summary>
[DisallowMultipleComponent]
public class UbhBullet : UbhMonoBehaviour
{
    protected Transform m_transformCache;
    protected UbhBaseShot m_parentBaseShot;
    protected float m_speed;
    protected float m_angle;
    protected float m_accelSpeed;
    protected float m_accelTurn;
    protected bool m_homing;
    protected Transform m_homingTarget;
    protected float m_homingAngleSpeed;
    protected bool m_wave;
    protected float m_waveSpeed;
    protected float m_waveRangeSize;
    protected bool m_pauseAndResume;
    protected float m_pauseTime;
    protected float m_resumeTime;
    protected bool m_useAutoRelease;
    protected float m_autoReleaseTime;
    protected UbhUtil.AXIS m_axisMove;
    protected bool m_useMaxSpeed;
    protected float m_maxSpeed;
    protected bool m_useMinSpeed;
    protected float m_minSpeed;

    protected float m_baseAngle;
    protected float m_selfFrameCnt;
    protected float m_selfTimeCount;

    protected UbhTentacleBullet m_tentacleBullet;

    protected bool m_shooting;

    public UbhBaseShot parentShot
    {
        get { return m_parentBaseShot; }
    }

    public float AutoReleaseTime
    {
        get { return m_autoReleaseTime; }
    }

    /// <summary>
    /// Activate/Inactivate flag
    /// Override this property when you want to change the behavior at Active / Inactive.
    /// </summary>
    public virtual bool isActive
    {
        get { return gameObject.activeSelf; }
    }

    private void Awake()
    {
        m_transformCache = transform;
        m_tentacleBullet = GetComponent<UbhTentacleBullet>();
    }

    protected virtual void OnDisable()
    {
        if (m_shooting == false)
        {
            return;
        }

        PoolContainer.DeSpawnBullet(this.transform);
    }

    /// <summary>
    /// Activate/Inactivate Bullet
    /// Override this method when you want to change the behavior at Active / Inactive.
    /// </summary>
    public virtual void SetActive(bool isActive)
    {
        gameObject.SetActive(isActive);
    }

    public float MAngle
    {
        get => m_angle;
        set => m_angle = value;
    }

    /// <summary>
    /// Finished Shot
    /// </summary>
    public void OnFinishedShot()
    {
        if (m_shooting == false)
        {
            return;
        }

        m_shooting = false;

        m_parentBaseShot = null;
        m_homingTarget = null;
        m_transformCache.ResetPosition();
        m_transformCache.ResetRotation();
    }

    public virtual void Shot(UbhBaseShot parentBaseShot,
        float speed, float angle)
    {
        Shot(parentBaseShot, speed, angle, 0, 0, false, null, 0, false, 0,
            0, false, 0, 0, false, 0, UbhUtil.AXIS.X_AND_Y,
            false, false, 0, false, 0);
    }

    /// <summary>
    /// Bullet Shot
    /// </summary>
    public virtual void Shot(UbhBaseShot parentBaseShot,
        float speed, float angle, float accelSpeed, float accelTurn,
        bool homing, Transform homingTarget, float homingAngleSpeed,
        bool wave, float waveSpeed, float waveRangeSize,
        bool pauseAndResume, float pauseTime, float resumeTime,
        bool useAutoRelease, float autoReleaseTime,
        UbhUtil.AXIS axisMove, bool inheritAngle,
        bool useMaxSpeed, float maxSpeed, bool useMinSpeed, float minSpeed)
    {
        if (m_shooting)
        {
            return;
        }

        Debug.Log("Shoot");
        
        m_shooting = true;

        m_parentBaseShot = parentBaseShot;

        // m_speed = speed;
        // m_useAutoRelease = useAutoRelease;
        // m_autoReleaseTime = autoReleaseTime;

        m_angle = angle;
        m_accelSpeed = accelSpeed;
        m_accelTurn = accelTurn;
        m_homing = homing;
        m_homingTarget = homingTarget;
        m_homingAngleSpeed = homingAngleSpeed;
        m_wave = wave;
        m_waveSpeed = waveSpeed;
        m_waveRangeSize = waveRangeSize;
        m_pauseAndResume = pauseAndResume;
        m_pauseTime = pauseTime;
        m_resumeTime = resumeTime;
        m_axisMove = axisMove;
        m_useMaxSpeed = useMaxSpeed;
        m_maxSpeed = maxSpeed;
        m_useMinSpeed = useMinSpeed;
        m_minSpeed = minSpeed;

        m_baseAngle = 0f;
        if (inheritAngle && m_parentBaseShot?.lockOnShot == false)
        {
            if (m_axisMove == UbhUtil.AXIS.X_AND_Z)
            {
                // X and Z axis
                m_baseAngle = m_parentBaseShot.shotCtrl.transform.eulerAngles.y;
            }
            else
            {
                // X and Y axis
                m_baseAngle = m_parentBaseShot.shotCtrl.transform.eulerAngles.z;
            }
        }

        if (m_axisMove == UbhUtil.AXIS.X_AND_Z)
        {
            // X and Z axis
            m_transformCache.SetEulerAnglesY(m_baseAngle - m_angle);
        }
        else
        {
            // X and Y axis
            m_transformCache.SetEulerAnglesZ(m_baseAngle + m_angle);
        }

        m_selfFrameCnt = 0f;
        m_selfTimeCount = 0f;
    }

    /// <summary>
    /// OnUpdate Move
    /// </summary>
    public virtual void UpdateMove(float deltaTime)
    {
        if (m_shooting == false)
        {
            return;
        }

        m_selfTimeCount += deltaTime;

        // auto release check
        if (ResolveRelease())
        {
            return;
        }

        // pause and resume.
        if (m_pauseAndResume && m_pauseTime >= 0f && m_resumeTime > m_pauseTime)
        {
            if (m_pauseTime <= m_selfTimeCount && m_selfTimeCount < m_resumeTime)
            {
                return;
            }
        }

        Vector3 myAngles = m_transformCache.rotation.eulerAngles;

        Quaternion newRotation = m_transformCache.rotation;
        if (m_homing)
        {
            // homing target.
            if (m_homingTarget != null && 0f < m_homingAngleSpeed)
            {
                float rotAngle = UbhUtil.GetAngleFromTwoPosition(m_transformCache, m_homingTarget, m_axisMove);
                float myAngle = 0f;
                if (m_axisMove == UbhUtil.AXIS.X_AND_Z)
                {
                    // X and Z axis
                    myAngle = -myAngles.y;
                }
                else
                {
                    // X and Y axis
                    myAngle = myAngles.z;
                }

                float toAngle = Mathf.MoveTowardsAngle(myAngle, rotAngle, deltaTime * m_homingAngleSpeed);

                if (m_axisMove == UbhUtil.AXIS.X_AND_Z)
                {
                    // X and Z axis
                    newRotation = Quaternion.Euler(myAngles.x, -toAngle, myAngles.z);
                }
                else
                {
                    // X and Y axis
                    newRotation = Quaternion.Euler(myAngles.x, myAngles.y, toAngle);
                }
            }
        }
        else if (m_wave)
        {
            // acceleration turning.
            m_angle += (m_accelTurn * deltaTime);
            // wave.
            if (0f < m_waveSpeed && 0f < m_waveRangeSize)
            {
                float waveAngle = m_angle + (m_waveRangeSize / 2f * Mathf.Sin(m_selfFrameCnt * m_waveSpeed / 100f));
                if (m_axisMove == UbhUtil.AXIS.X_AND_Z)
                {
                    // X and Z axis
                    newRotation = Quaternion.Euler(myAngles.x, m_baseAngle - waveAngle, myAngles.z);
                }
                else
                {
                    // X and Y axis
                    newRotation = Quaternion.Euler(myAngles.x, myAngles.y, m_baseAngle + waveAngle);
                }
            }

            m_selfFrameCnt += UbhTimer.instance.deltaFrameCount;
        }
        else
        {
            // acceleration turning.
            float addAngle = m_accelTurn * deltaTime;
            if (m_axisMove == UbhUtil.AXIS.X_AND_Z)
            {
                // X and Z axis
                newRotation = Quaternion.Euler(myAngles.x, myAngles.y - addAngle, myAngles.z);
            }
            else
            {
                // X and Y axis
                newRotation = Quaternion.Euler(myAngles.x, myAngles.y, myAngles.z + addAngle);
            }
        }

        // acceleration speed.
        m_speed += (m_accelSpeed * deltaTime);

        if (m_useMaxSpeed && m_speed > m_maxSpeed)
        {
            m_speed = m_maxSpeed;
        }

        if (m_useMinSpeed && m_speed < m_minSpeed)
        {
            m_speed = m_minSpeed;
        }

        // move.
        Vector3 newPosition;
        if (m_axisMove == UbhUtil.AXIS.X_AND_Z)
        {
            // X and Z axis
            newPosition = m_transformCache.position + (m_transformCache.forward * (m_speed * deltaTime));
        }
        else
        {
            // X and Y axis
            newPosition = m_transformCache.position + (m_transformCache.up * (m_speed * deltaTime));
        }

        // set new position and rotation
        m_transformCache.SetPositionAndRotation(newPosition, newRotation);

        if (m_tentacleBullet != null)
        {
            // OnUpdate tentacles
            m_tentacleBullet.UpdateRotate();
        }
    }

    public virtual bool ResolveRelease()
    {
        if (m_useAutoRelease && m_autoReleaseTime > 0f)
        {
            if (m_selfTimeCount >= m_autoReleaseTime)
            {
                // Release
                PoolContainer.DeSpawnBullet(this.transform);
                return true;
            }
        }

        return false;
    }
}