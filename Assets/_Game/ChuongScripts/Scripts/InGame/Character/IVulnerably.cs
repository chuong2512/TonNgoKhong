namespace Game
{
    using UnityEngine;

    public interface IVulnerably
    {
        public float MaxHealth { get; }
        public float Health { get; }
    }
}