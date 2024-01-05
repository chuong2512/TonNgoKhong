namespace Game
{
    using System;
    using System.Collections.Generic;
    using Sirenix.OdinInspector;
    using UnityEngine;

    public struct DamageTakenInfo
    {
        public float DamageIncome;
        public float DamageTakenBeforeReduction;
        public float DamageTakenAfterReduction;
        public float FinalDamageTaken;
        public bool MayBeFatal;
        public float TotalDamageTaken;
        public int TotalHitReceivedCount;

        public void IncreaseHitCount()
        {
            TotalHitReceivedCount += 1;
        }

        public void Reset()
        {
            DamageIncome = 0;
            DamageTakenBeforeReduction = 0;
            DamageTakenAfterReduction = 0;
            FinalDamageTaken = 0;
            MayBeFatal = false;
        }
    }

    public class PlayerCombat : MonoBehaviour, ICombat
    {
        private bool _healthDamageEnabled;
        private DamageTakenInfo _damageTakenInfo;
        private Dictionary<int, float> _damageSlots;

        private int _currentSlot;

        private void Start()
        {
            _healthDamageEnabled = true;
            _damageTakenInfo = new DamageTakenInfo();
            _damageSlots = new Dictionary<int, float>();
        }

        public void TakeHeal(HealInfo healInfo)
        {
        }

        public void TakeDamage(DamageInfo damageInfo)
        {
        }

        public void TakeDamageByHealthPercent(float healthPercent)
        {
        }

        public bool IsDestroyed()
        {
            return false;
        }
    }
}