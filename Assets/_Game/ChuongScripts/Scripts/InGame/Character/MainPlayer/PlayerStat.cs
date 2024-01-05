using Skill;

namespace Game
{
    public class PlayerAttribute : IHealthAttribute,IMaxHealthAttribute, IVirtualHealthAttribute, IDamageAttribute,
        IDefenseAttribute, ISpeedAttribute
    {
        public float Health { get; set; }

        public float MaxHealth { get; set; }
        public float VirtualHealth { get; set; }
        public float Damage { get; set; }
        public float Defense { get; set; }
        public float Speed { get; set; }
    }
}