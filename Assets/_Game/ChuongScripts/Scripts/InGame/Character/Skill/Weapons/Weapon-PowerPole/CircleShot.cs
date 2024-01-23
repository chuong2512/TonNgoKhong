using System.Collections;
using System.Collections.Generic;
using Game;
using Game.Weapons;
using UnityEngine;

public class CircleShot : PlayerShot
{
    [SerializeField] protected LockShot _usingShot;

    [SerializeField] private float _delayBetween = 0.5f;

    private bool _forceStop;
    private float _counter;

    private float _dmg;
    private int _amount;

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
        if (_counter < 0)
        {
            Shoot();
            _counter = _delayBetween;
        }
    }

    private void Shoot()
    {
        for (int i = 0; i < _amount; i++)
        {
            _usingShot.SetAngle(360 / _amount * i);
            _usingShot.Shot();
        }
    }

    private void FixedUpdate()
    {
        if (_counter < 0)
        {
            RotateAndShoot();
        }

        _counter -= Time.fixedDeltaTime;
    }
}