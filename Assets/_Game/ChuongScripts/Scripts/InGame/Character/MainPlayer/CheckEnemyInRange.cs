using System.Collections.Generic;
using SinhTon;
using UnityEngine;

namespace Game
{
    [RequireComponent(typeof(Collider2D))]
    public class CheckEnemyInRange : Singleton<CheckEnemyInRange>
    {
        private List<BaseEnemy> _enemies;
        
        public List<BaseEnemy>  GetAllEnemiesInRange()
        {
            foreach (var enemy in _enemies)
            {
               
            }

            return _enemies;
        }
    }
}