using UnityEngine;

namespace Game
{
    public class Tower : MonoBehaviour
    {
        public void SetPos(Vector3 randPos)
        {
            transform.rotation = Quaternion.identity;
            transform.position = randPos;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            var combat = other.GetComponentInParent<BaseEnemy>();
            if (combat != null && !combat.IsDestroyed())
            {
                var damageInfo = new DamageInfo(10, 0);

                combat.TakeDamage(damageInfo);
            }
        }

        public void Despawn()
        {
            PoolContainer.DeSpawnItem(transform);
        }
    }
}