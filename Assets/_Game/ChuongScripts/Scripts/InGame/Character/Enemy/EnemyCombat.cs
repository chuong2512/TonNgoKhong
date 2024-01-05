
namespace Game
{
    using Sirenix.OdinInspector;
    using UnityEngine;

    [System.Serializable]
    public class EnemyCombat
    {
        [ReadOnly] [ShowInInspector] private float _health;
        [ReadOnly] [ShowInInspector] private float _maxHealth;
        [ReadOnly] [ShowInInspector] private float _def;
        [ReadOnly] [ShowInInspector] private float _baseDef;

        [ReadOnly] [ShowInInspector] private float _runtimeBuffHealth;

        private float       _cachedMaxHealth;
        public  float       Health    => _health;
        public  float       MaxHealth => _maxHealth;

        private float _cacheDef;

        public void Bind(float hp, float def)
        {
            _cachedMaxHealth = hp;
            _maxHealth       = _cachedMaxHealth * (1 + _runtimeBuffHealth / 100);
            _baseDef         = def;
            _def             = def;
            _cacheDef        = def;
            
            if (_health <= 0f)
            {
                _health = _maxHealth;
            }
        }

        public void AddRuntimeBuffHealth(float additional)
        {
            _runtimeBuffHealth += additional;
            
            if (_maxHealth <= 1)
                return;
            
            var currentHealthPercent = _health / _maxHealth;
            
            _maxHealth = _cachedMaxHealth * (1 + _runtimeBuffHealth / 100);
            _health    = _maxHealth * currentHealthPercent;
        }

        //calculate every got hit
        internal void UpdateDefWhenHit(float defDecreasePercent)
        {
            float newDef = _def * (1 - defDecreasePercent / 100f);
            _cacheDef = Mathf.Clamp(newDef, 0f, _def);
        }

        internal void UpdateFlatDef(float defIncrease)
        {
            _def += defIncrease;
            _def =  Mathf.Clamp(_def, 0f, _baseDef);
        }
        
        internal void UpdateDefByPercent(float percent)
        {
            _def += percent / 100 * _baseDef;
            _def =  Mathf.Clamp(_def, 0f, Mathf.Infinity);
        }

        internal float GetDamageTaken(float trueDamage)
        {
            return trueDamage;
        }

        internal void MinusHealth(float damageTaken)
        {
            _health   -= damageTaken;
            _cacheDef =  _def;
        }

        internal void Healing(HealInfo info)
        {
            _health += info.flatHeal + _maxHealth * info.percentageHeal / 100f;
            _health =  Mathf.Clamp(_health, 0f, _maxHealth);
        }
    }
}