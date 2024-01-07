using Game;
using UnityEngine;

namespace Skill.Weapons
{
    public class PowerPoleController : BaseSkillController<PowerPoleAttribute>
    {
        [SerializeField] private PowerPoleShot _shot;

        [SerializeField] private float _baseDmg = 10;
        [SerializeField] private int _baseAmount = 1;
        [SerializeField] private float speed = 1;
        [SerializeField] private float lifeTime = 5;

        public PowerPoleController()
        {
            attribute = new PowerPoleAttribute();
        }

        public float Damage => (_baseDmg + attribute.Damage) * (1 + attribute.PercentDamage);
        public int Amount => _baseAmount * attribute?.MultipleAmount ?? 0;
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
        }
    }
}