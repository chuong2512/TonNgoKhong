using System;
using Game;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Game
{
    public class TowerController : BaseSkillController<TowerAttribute>
    {
        [SerializeField] private Tower _tower;

        [SerializeField] private float _delayBetween = 2f;

        private float _counter;
        private Transform _playerTrans;

        private void Start()
        {
            _playerTrans = PlayerManager.Instance.PlayerTransform;
        }

        private void FixedUpdate()
        {
            if (_counter >= _delayBetween)
            {
                _counter = 0;
                Shoot();
            }

            _counter += Time.fixedDeltaTime;
        }

        private void Shoot()
        {
            var tower = PoolContainer.SpawnItem(_tower.transform).GetComponent<Tower>();

            var randPos = _playerTrans.position + (Vector3) (Random.insideUnitCircle.normalized * Random.Range(3f, 4f));

            tower.SetPos(randPos);
        }

        public override void Refresh()
        {
        }
    }
}

public class TowerAttribute : IDamageAttribute, IAmountAttribute
{
    public TowerAttribute()
    {
        Amount = 1;
    }

    public float Damage { get; set; }
    public int Amount { get; set; }
}