using System.Collections;
using System.Collections.Generic;
using Game;
using Game.Weapons;
using UnityEngine;

public class RotateShot : PlayerShot
{
    [SerializeField] protected LockShot _usingShot;

    [SerializeField] private float _delayBetween = 0.1f;
    [SerializeField] private float _timeDelay = 5;

    private bool _forceStop;
    private bool _isDelay;
    private float _counter;

    private float _dmg;
    private int _amount;

    private float angle;

    public override int Amount
    {
        get => _amount;
        set => _amount = value;
    }

    public override float SpeedShotTime { get; set; }

    public float Dmg
    {
        get => _dmg;
        set => _dmg = value;
    }

    public override void SetBulletAttribute(BulletAttribute attribute)
    {
        _usingShot.SetBulletAttribute(attribute);
    }


    protected void RotateAndShoot()
    {
        Shoot();
        _counter = 0;
    }

    private void Shoot()
    {
        _usingShot.SetAngle(angle);
        _usingShot.Shot();

        angle += 4;

        if (angle > 360)
        {
            angle = 0;
            _isDelay = true;
        }
    }

    private void FixedUpdate()
    {
        if (_isDelay)
        {
            if (_counter > _timeDelay)
            {
                _isDelay = false;
                _counter = 0;
                RotateAndShoot();
            }
        }
        else
        {
            if (_counter > _delayBetween)
            {
                RotateAndShoot();
            }
        }

        _counter += Time.fixedDeltaTime;
    }

    public void ReBind()
    {
        _counter = _delayBetween;
    }

    public void RestartShot()
    {
        _forceStop = false;
    }

    public virtual void StopShot()
    {
        if (_usingShot != null)
        {
            _usingShot.StopShot();
        }
    }

    public virtual void ForceStopShot()
    {
        _forceStop = true;
        StopShot();
    }

    public void SetTarget(Transform target)
    {
        _usingShot.SetTarget(target);
    }
}