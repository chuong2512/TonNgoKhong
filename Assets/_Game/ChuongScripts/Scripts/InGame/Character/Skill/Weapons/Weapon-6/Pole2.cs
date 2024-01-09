using Game;
using UnityEngine;

namespace _Game.Weapons.Weapon_6
{
    public class Pole2 : MonoBehaviour
    {
        [SerializeField] private float Damage = 4;
        protected virtual void OnTriggerEnter2D(Collider2D other)
        {
            var combat = other.GetComponentInParent<BaseEnemy>();
            if (combat != null && !combat.IsDestroyed())
            {
                var damageInfo = new DamageInfo(Damage, 0);

                combat.TakeDamage(damageInfo);
            }
        }
    }
}