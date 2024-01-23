using System;
using System.Collections.Generic;
using Game;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Weapons
{
    public class MultipleShot : PlayerShot
    {
        private readonly IAiming _aiming = new RegularAiming();

        [Space] [SerializeField] protected UnityEvent _shotFiredCallbackEvents = new UnityEvent();

        [SerializeField] protected OneBulletShot _usingShot;

        [SerializeField] private float _delayBetween = 0.5f;

        private bool _forceStop;
        private float _counter;
        private float _speedShotTime;

        private float _dmg;
        private int _amount;

        public override int Amount
        {
            get => _amount;
            set => _amount = value;
        }

        public override float SpeedShotTime
        {
            get => _speedShotTime;
            set => _speedShotTime = value;
        }

        public float Dmg
        {
            get => _dmg;
            set => _dmg = value;
        }

        private float BetweenTime => _delayBetween - _speedShotTime;
        
        public override void SetBulletAttribute(BulletAttribute attribute)
        {
            _usingShot.SetBulletAttribute(attribute);
        }

        public void Shot()
        {
            if (_forceStop) return;
            ShotImmediate();
        }

        protected void RotateAndShoot(List<Transform> target)
        {
            if (target == null)
            {
                return;
            }

            if (_counter < 0)
            {
                Shoot(target);
                _counter = BetweenTime;
            }
        }

        private void Shoot(List<Transform> target)
        {
            var count = Mathf.Min(_amount, target.Count);

            for (int i = 0; i < count; i++)
            {
                SetTarget(target[i]);
                Shot();
            }
        }

        //----Animation Event-------------------------------------------------------------------------------------------
        public void ShotImmediate()
        {
            if (!_usingShot.IsShoting())
                _shotFiredCallbackEvents.Invoke();
            _usingShot.Shot();
        }

        private void FixedUpdate()
        {
            if (_counter < 0)
            {
                if (_aiming.HasTarget)
                {
                    RotateAndShoot(_aiming.Targets);
                }
            }

            _counter -= Time.fixedDeltaTime;
        }

        public void ReBind()
        {
            _counter = BetweenTime;
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
}