using System;
using UnityEngine;

namespace Game
{
    public class PlayerCombat : MonoBehaviour, ICombat
    {
        private PlayerStatus _playerStatus;

        public PlayerStatus PlayerStatus
        {
            get => _playerStatus;
            set => _playerStatus = value;
        }

        public void InitHealth()
        {
            Health = MaxHealth;
            InGameAction.OnHealthChange?.Invoke();
        }

        public void RestoreHP()
        {
            InitHealth();
        }
        
        public void TakeHeal(HealInfo healInfo)
        {
            var flatHeal = healInfo.flatHeal;

            if (healInfo.healLostByPercent > 0)
            {
                flatHeal += healInfo.healLostByPercent * (MaxHealth - Health) / 100;
            }

            Healing(flatHeal, healInfo.percentageHeal);
        }

        public void Healing(float flatHeal, float percent, bool isExtra = false)
        {
            if (Health > 0 && (percent > 0 || flatHeal > 0))
            {
                var healingAmount = flatHeal + MaxHealth * percent / 100f;
                var excessAmount = Mathf.Clamp(Health + healingAmount - MaxHealth, 0,
                    Int32.MaxValue);

                Health += healingAmount;
                Health = Mathf.Clamp(Health, 0, MaxHealth);
                /*UITextDamageManager.Instance.ShowText(healingAmount, true, transform.position,
                    DamageType.PlayerHealing);*/

                InGameAction.OnHealthChange?.Invoke();
            }
        }

        public void TakeDamage(DamageInfo damageInfo)
        {
            if (damageInfo.trueDamage == 0)
            {
                Health -= (damageInfo.damageByHpPercent * MaxHealth - Defense);
            }
            else
            {
                Health -= (damageInfo.trueDamage - Defense);
            }

            InGameAction.OnHealthChange?.Invoke();

            if (Health <= 0)
            {
                InGameAction.OnPlayerDie?.Invoke();
                ScreenManager.Instance.OpenScreen(ScreenType.Result, new ResultModel(false));
            }
        }

        public void TakeDamageByHealthPercent(float healthPercent)
        {
            TakeDamage(new DamageInfo(0, healthPercent));
        }

        public void TakeDamage(float trueDamage)
        {
            TakeDamage(new DamageInfo(trueDamage, 0));
        }

        public bool IsDestroyed()
        {
            return _playerStatus.Health <= 0f;
        }

        public float MaxHealth => _playerStatus.MaxHealth;
        public float Defense => _playerStatus.Defense;
        
        public float Damage => _playerStatus.Damage;

        public float Health
        {
            get => _playerStatus.Health;
            set => _playerStatus.Health = value;
        }

        public float PercentHealth => Health / MaxHealth;
    }
}