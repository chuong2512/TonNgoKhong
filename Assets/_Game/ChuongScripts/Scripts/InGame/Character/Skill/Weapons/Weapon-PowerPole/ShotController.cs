using Game;
using UnityEngine;

namespace Game.Weapons
{
    public class ShotController : BaseSkillController<ShotWeaponAttribute>
    {
        [SerializeField] private PlayerShot _shot;

        [SerializeField] private float _baseDmg = 10;
        [SerializeField] private int _baseAmount = 1;
        [SerializeField] private float speed = 1;
        [SerializeField] private float lifeTime = 5;

        public ShotController()
        {
            attribute = new ShotWeaponAttribute();
        }

        public float Damage => (_baseDmg + attribute.Damage + PlayerManager.Instance.Combat.Damage) *
                               (1 + attribute.PercentDamage);

        public int Amount => (_baseAmount + attribute.Amount) * attribute.MultipleAmount;
        public float Speed => speed + attribute.Speed;

        public override void Refresh()
        {
            _shot.SetBulletAttribute(new BulletAttribute()
            {
                Damage = Damage,
                Speed = Speed,
                LifeTime = lifeTime,
            });
            _shot.Amount = Amount;
            _shot.SpeedShotTime = attribute.SpeedShot;
        }
    }
}