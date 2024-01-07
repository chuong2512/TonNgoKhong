using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class EnemyAnimator : AEnemyAnimator
    {
        [ChildGameObjectsOnly] public Animator animator;
        [SerializeField] private int _shootLayer = 0;

        private int _shootHash = Animator.StringToHash("TriggerShot");
        private int _moveHash = Animator.StringToHash("Move");
        private int _deadHash = Animator.StringToHash("Die");
        private int _aimHash = Animator.StringToHash("IsAim");
        private int _knockHash = Animator.StringToHash("Knock");

        public override void TriggerShoot()
        {
            if (animator != null)
                animator.SetTrigger(_shootHash);
        }

        public override void SetWalk(bool walk)
        {
        }

        public override void SetMovement(int speed)
        {
            if (animator != null)
            {
                animator.SetInteger(_moveHash, speed);
            }
        }

        public override void SetDead(bool dead)
        {
            if (animator != null)
                animator.SetBool(_deadHash, dead);
        }

        public override void SetAiming(bool IsAiming)
        {
            if (animator != null)
                animator.SetBool(_aimHash, IsAiming);
        }

        public override void SetKnock(bool knock)
        {
            if (animator != null)
                animator.SetBool(_knockHash, knock);
        }

        public override bool TriggeredShot()
        {
            var stateInfo = animator.GetCurrentAnimatorStateInfo(_shootLayer);
            if (stateInfo.IsName("shoot"))
            {
                float progress = stateInfo.normalizedTime % 1;
                return progress >= _triggerShotAnim;
            }

            return false;
        }

        public override void Active(bool active)
        {
            animator.enabled = active;
        }
    }
}