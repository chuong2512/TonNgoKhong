using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class RegularAiming : IAiming
    {
        public void RotationToTarget(Transform rotator, Vector3 targetPosition)
        {
            var dir = rotator.position - targetPosition;
            dir.z = 0;
            var facingRotation = Quaternion.LookRotation(dir, Vector3.back);

            rotator.rotation = facingRotation;
        }

        public void RestRotation(Transform rotator, Quaternion restRotation)
        {
            rotator.localRotation = restRotation;
        }

        public bool HasTarget => Targets is {Count: > 0};

        public List<Transform> Targets
        {
            get
            {
                var activeEnemies = CheckEnemyInRange.Instance.GetAllEnemiesInRange();

                var result = new List<Transform>();

                if (activeEnemies.Count > 0)
                {
                    foreach (var e in activeEnemies)
                    {
                        result.Add(e.colliderTarget);
                    }
                }

                return result;
            }
        }
    }
}