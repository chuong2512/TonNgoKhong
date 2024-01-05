using Game;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace Skill.Weapons
{
    public class PowerPoleShot : SerializedMonoBehaviour
    {
        [SerializeField] protected IAiming _aiming;

        [Space] [SerializeField] protected UnityEvent _shotFiredCallbackEvents = new UnityEvent();

        public Transform gunRotateRig;

        [SerializeField] protected LayerMask _obstacleLayer = 1 << 3 | 1 << 10;
        [SerializeField] protected Transform _barrel;
        [SerializeField] protected Animator _animator;

        protected IPlayerShot _usingShot;

        protected float _animatorSpeed;
        protected bool _forceStop;

        protected static readonly int ShotTrigger = Animator.StringToHash("shot");
        protected static readonly int ForceStopShotTrigger = Animator.StringToHash("ForceStop");
        protected static string ExceptionTag = "Rooftop";

        protected float _counter;
        protected float _range = 100f;

        protected float _delayBetween;
        protected Quaternion _originRotation;
        protected Transform _cachedTrans;

        protected virtual void Awake()
        {
            _cachedTrans = transform;
            _originRotation = gunRotateRig.localRotation;
        }

        protected virtual void Start()
        {
            //init gun
            SetBarrel();
        }

        public void UpdateRange(float range)
        {
            _range = range;
        }

        public void Shot()
        {
            if (_forceStop) return;

            if (_animator == null)
            {
                ShotImmediate();
            }
            else
            {
                _animator.ResetTrigger(ForceStopShotTrigger);
                _animator.SetTrigger(ShotTrigger);
            }
        }

        public virtual void UpdateGun(float deltaTime)
        {
            _aiming.FindTarget(_cachedTrans.position, _range, _obstacleLayer, ExceptionTag);

            if (!_aiming.HasTarget)
            {
                StopShot();
                _aiming.RestRotation(gunRotateRig, _originRotation);
            }
            else
            {
                RotateAndShoot(_aiming.Target);
            }

            _counter -= Time.fixedDeltaTime;
        }

        protected void RotateAndShoot(Transform target)
        {
            if (target == null)
            {
                return;
            }

            _aiming.RotationToTarget(gunRotateRig, target.position);

            if (_counter < 0)
            {
                Shoot(target);
                _counter = _delayBetween;
            }
        }

        protected virtual void Shoot(Transform target)
        {
            SetTarget(target);
            Shot();
        }

        public void SetDefaultRotation()
        {
            _aiming.RestRotation(gunRotateRig, _originRotation);
        }

        public virtual void ChangeAnimatorSpeed(float additional)
        {
            if (_animator)
            {
                _animator.speed += additional;
                _animator.speed = Mathf.Clamp(_animator.speed, 0.1f, 10f);
            }

            _animatorSpeed += additional;
            _animatorSpeed = Mathf.Clamp(_animatorSpeed, 0.1f, 10f);
        }

        public virtual void UpdateFireRate(float attackSpeed)
        {
            _delayBetween = 1f / attackSpeed;
        }

        //----Animation Event-------------------------------------------------------------------------------------------
        public void ShotImmediate()
        {
            if (!_usingShot.IsShoting())
                _shotFiredCallbackEvents.Invoke();
            _usingShot.Shot();
        }


        public void ReBind()
        {
            _counter = _delayBetween;
        }

        //using in animation trigger event, ex : shotgun
        public void OnAnimationEvent_Shot()
        {
            if (_forceStop) return;

            _aiming.FindTarget(_cachedTrans.position, _range, _obstacleLayer, ExceptionTag);

            if (!_usingShot.IsShoting() && _aiming.HasTarget)
            {
                SetTarget(_aiming.Target);
                _shotFiredCallbackEvents.Invoke();
                _usingShot.Shot();
            }
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

            if (_animator != null)
            {
                _animator.SetTrigger(ForceStopShotTrigger);
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

        public void SetBarrel()
        {
            _usingShot.SetBarrel(_barrel);
        }

        public float AnimatorSpeed => _animatorSpeed;

        public IAiming Aiming => _aiming;
        public float DelayBetween => _delayBetween;
    }
}