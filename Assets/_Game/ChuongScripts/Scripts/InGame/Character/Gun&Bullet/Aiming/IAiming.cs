namespace Game
{
    using UnityEngine;

    public interface IAiming
    {
        /// <summary>
        /// This function run on FixedUpdate of PlayerGun, so can use Time.fixDeltaTime as a tick
        /// </summary>
        /// <param name="currentPosition">Use to check distance to target</param>
        /// <param name="range">Range in which find target</param>
        /// <param name="layerMask">Layer that raycast fired to select target</param>
        /// <param name="exceptionTag">The tag of target that can bypass layermask condition</param>
        void FindTarget(Vector3 currentPosition, float range, LayerMask layerMask, string exceptionTag);

        /// <summary>
        /// This function run on PlayerGun fixedUpdate if target detected
        /// </summary>
        /// <param name="rotator">The transform that need to be rotate toward target's position</param>
        /// <param name="targetPosition"></param>
        void RotationToTarget(Transform rotator, Vector3 targetPosition);

        /// <summary>
        /// This function run on PlayerGun fixedUpdate if target CAN NOT be detected
        /// </summary>
        /// <param name="rotator">The transform that need to be rotate toward idle position</param>
        /// <param name="restRotation">The direction that rotator will rest when no target was found</param>
        void RestRotation(Transform rotator, Quaternion restRotation);

        bool HasTarget { get; }
        Transform Target { get; }
    }
}