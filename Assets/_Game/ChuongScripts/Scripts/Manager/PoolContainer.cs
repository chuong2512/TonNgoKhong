using PathologicalGames;
using SinhTon;
using UnityEngine;

public class PoolConstant
{
    public static readonly string PoolEnemy = "Enemy";
    public static readonly string PoolParticle = "Particle";
    public static readonly string PoolItem = "Item";
}

namespace _TonNgoKhong
{
    public class PoolContainer : Singleton<PoolContainer>
    {
        public void SpawnEnemy(Transform prefab, Vector3 pos, Quaternion rot, Transform parent)
        {
            PoolManager.Pools[PoolConstant.PoolEnemy].Spawn(prefab, pos, rot, parent);
        }

        public void SpawnEnemy(string name, Vector3 pos, Quaternion rot, Transform parent)
        {
            PoolManager.Pools[PoolConstant.PoolEnemy].Spawn(name, pos, rot, parent);
        }

        public void SpawnEnemy(Transform prefab, Transform parent)
        {
            PoolManager.Pools[PoolConstant.PoolEnemy].Spawn(prefab, parent);
        }

        public void SpawnEnemy(string name, Transform parent)
        {
            PoolManager.Pools[PoolConstant.PoolEnemy].Spawn(name, parent);
        }

        public void SpawnFX(Transform prefab, Vector3 pos, Quaternion rot, Transform parent)
        {
            PoolManager.Pools[PoolConstant.PoolParticle].Spawn(prefab, pos, rot, parent);
        }

        public void SpawnFX(string name, Vector3 pos, Quaternion rot, Transform parent)
        {
            PoolManager.Pools[PoolConstant.PoolParticle].Spawn(name, pos, rot, parent);
        }

        public void SpawnFX(Transform prefab, Transform parent)
        {
            PoolManager.Pools[PoolConstant.PoolParticle].Spawn(prefab, parent);
        }

        public void SpawnFX(string name, Transform parent)
        {
            PoolManager.Pools[PoolConstant.PoolParticle].Spawn(name, parent);
        }

        public void SpawnItem(Transform prefab, Vector3 pos, Quaternion rot, Transform parent)
        {
            PoolManager.Pools[PoolConstant.PoolItem].Spawn(prefab, pos, rot, parent);
        }

        public void SpawnItem(string name, Vector3 pos, Quaternion rot, Transform parent)
        {
            PoolManager.Pools[PoolConstant.PoolItem].Spawn(name, pos, rot, parent);
        }

        public void SpawnItem(Transform prefab, Transform parent)
        {
            PoolManager.Pools[PoolConstant.PoolItem].Spawn(prefab, parent);
        }

        public void SpawnItem(string name, Transform parent)
        {
            PoolManager.Pools[PoolConstant.PoolItem].Spawn(name, parent);
        }

        public void DeSpawnFX(Transform trans)
        {
            PoolManager.Pools[PoolConstant.PoolParticle].Despawn(trans);
        }

        public void DeSpawnItem(Transform trans)
        {
            PoolManager.Pools[PoolConstant.PoolItem].Despawn(trans);
        }

        public void DeSpawnEnemy(Transform trans)
        {
            PoolManager.Pools[PoolConstant.PoolEnemy].Despawn(trans);
        }
    }
}