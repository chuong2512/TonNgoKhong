using UnityEngine;

namespace Game
{
    public class RegularAiming : IAiming
    {
        public void FindTarget(Vector3 currentPosition, float range, LayerMask layerMask, string exceptionTag)
        {
            var activeEnemies = CheckEnemyInRange.Instance.GetAllEnemiesInRange();

            Target = null;
            HasTarget = false;

            float highestPriority = -1;

            for (int i = 0; i < activeEnemies.Count; i++)
            {
                var enemy = activeEnemies[i];
                if (enemy.IsDestroyed()) continue;

                var dir = enemy.colliderTarget.position - currentPosition;
                var distance = Vector2.SqrMagnitude(dir);
                distance = Mathf.Pow(distance, 0.5f);

                var hit = Physics2D.Raycast(currentPosition, dir, distance, layerMask);
                if (hit)
                {
                    if (string.IsNullOrEmpty(exceptionTag))
                    {
                        continue;
                    }

                    if (!string.IsNullOrEmpty(exceptionTag) && !hit.collider.CompareTag(exceptionTag))
                    {
                        continue;
                    }
                }

                if (distance - enemy.EnemySize < range)
                {
                    var priority = enemy.Priority + Mathf.Clamp(range / distance / 1.5f, 0, 6f);
                    if (priority > highestPriority)
                    {
                        highestPriority = priority;
                        Target = enemy.colliderTarget;
                    }

                    HasTarget = true;
                }
            }
        }

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

        public bool HasTarget { get; private set; }
        public Transform Target { get; private set; }
    }
}