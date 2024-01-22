using Game;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Game.Weapons
{
    public abstract class PlayerShot : SerializedMonoBehaviour
    {
        public abstract void SetBulletAttribute(BulletAttribute bulletAttribute);

        public abstract int Amount { get; set; }
        public abstract float SpeedShotTime { get; set; }
    }
}