using System.Collections.Generic;

namespace Game
{
    using UnityEngine;

    public interface IAiming
    {
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
        List<Transform> Targets { get; }
    }
}