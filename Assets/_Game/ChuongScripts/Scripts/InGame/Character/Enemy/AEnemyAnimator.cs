using UnityEngine;

namespace Game
{
    public abstract class AEnemyAnimator : MonoBehaviour
    {
        public static int MOVE_VALUE_IDLE = 0;
        public static int MOVE_VALUE_WALK = 1;
        public static int MOVE_VALUE_RUN = 2;
        public static int MOVE_VALUE_PARACHUTE = 3;
        public static int MOVE_VALUE_DIVEDOWN = 4;
        public static int MOVE_VALUE_RESURFACE = 5;

        [SerializeField] [Range(0, 1)] protected float _triggerShotAnim;

        public abstract void TriggerShoot();

        public abstract void SetWalk(bool walk);
        public abstract void SetMovement(int speed);

        public abstract void SetDead(bool dead);

        public abstract void SetAiming(bool IsAiming);

        public abstract void SetKnock(bool knock);

        public abstract bool TriggeredShot();

        public abstract void Active(bool active);
    }
}