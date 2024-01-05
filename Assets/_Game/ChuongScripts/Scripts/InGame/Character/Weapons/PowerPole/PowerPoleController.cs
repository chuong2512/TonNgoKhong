using UnityEngine;

namespace Skill.Weapons
{
    public class PowerPoleController : BaseSkillController<PowerPoleAttribute>
    {
        [SerializeField] private PowerPoleShot _shot;

        [SerializeField] private float baseDmg = 10;
        [SerializeField] private int baseAmount = 1;

        public float Damage => (baseDmg + attribute.Damage) * (1 + attribute.PercentDamage);
        public int Amount => baseAmount * attribute.MultipleAmount;

        public void Shot()
        {
            //taodan
            //
        }
    }
}