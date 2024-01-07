﻿using System;
using Skill;
using UnityEngine;

namespace Game
{
    [Serializable]
    public class PlayerAttribute : PlayerStat, IHealthAttribute
    {
        [field: SerializeField] public float Health { get; set; }
        /*[field: SerializeField] public float MaxHealth { get; set; } = 100;
        [field: SerializeField] public float VirtualHealth { get; set; } = 0;
        [field: SerializeField] public float Damage { get; set; } = 1;
        [field: SerializeField] public float Defense { get; set; } = 0;
        [field: SerializeField] public float Speed { get; set; } = 3;
        [field: SerializeField] public float Magnet { get; set; } = 1;*/
    }

    [Serializable]
    public class PlayerStat : IMaxHealthAttribute, IVirtualHealthAttribute, IDamageAttribute,
        IDefenseAttribute, ISpeedAttribute, IMagnetAttribute
    {
        [field: SerializeField] public float MaxHealth { get; set; } = 100;
        [field: SerializeField] public float VirtualHealth { get; set; } = 0;
        [field: SerializeField] public float Damage { get; set; } = 1;
        [field: SerializeField] public float Defense { get; set; } = 0;
        [field: SerializeField] public float Speed { get; set; } = 3;
        [field: SerializeField] public float Magnet { get; set; } = 1;
    }
}