using UnityEngine;

namespace Game
{
    public class DeadSMB : StateMachineBehaviour
    {
        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            base.OnStateUpdate(animator, stateInfo, layerIndex);

            float progress = stateInfo.normalizedTime % 1;

            if (progress > 0.95)
            {
                PoolContainer.DeSpawnEnemy(animator.gameObject.GetComponentInParent<BaseEnemy>().transform);
            }
        }
    }
}