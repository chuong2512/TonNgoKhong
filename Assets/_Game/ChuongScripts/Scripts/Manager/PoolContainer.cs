namespace Game
{
    using PathologicalGames;
    using UnityEngine;

    public class PoolConstant
    {
        public static readonly string PoolEnemy = "Enemy";
        public static readonly string PoolParticle = "Particle";
        public static readonly string PoolItem = "Item";
    }

    public static class PoolContainer
    {
        public static Transform SpawnEnemy(Transform prefab, Vector3 pos, Quaternion rot, Transform parent = null)
        {
            return PoolManager.Pools[PoolConstant.PoolEnemy].Spawn(prefab, pos, rot, parent);
        }

        public static Transform SpawnEnemy(string name, Vector3 pos, Quaternion rot, Transform parent = null)
        {
            return PoolManager.Pools[PoolConstant.PoolEnemy].Spawn(name, pos, rot, parent);
        }

        public static Transform SpawnEnemy(Transform prefab, Transform parent = null)
        {
            return PoolManager.Pools[PoolConstant.PoolEnemy].Spawn(prefab, parent);
        }

        public static Transform SpawnEnemy(string name, Transform parent = null)
        {
            return PoolManager.Pools[PoolConstant.PoolEnemy].Spawn(name, parent);
        }

        public static Transform SpawnFX(Transform prefab, Vector3 pos, Quaternion rot, Transform parent = null)
        {
            return PoolManager.Pools[PoolConstant.PoolParticle].Spawn(prefab, pos, rot, parent);
        }

        public static Transform SpawnFX(string name, Vector3 pos, Quaternion rot, Transform parent = null)
        {
            return PoolManager.Pools[PoolConstant.PoolParticle].Spawn(name, pos, rot, parent);
        }

        public static Transform SpawnFX(Transform prefab, Transform parent = null)
        {
            return PoolManager.Pools[PoolConstant.PoolParticle].Spawn(prefab, parent);
        }

        public static Transform SpawnFX(string name, Transform parent = null)
        {
            return PoolManager.Pools[PoolConstant.PoolParticle].Spawn(name, parent);
        }

        public static Transform SpawnItem(Transform prefab, Vector3 pos, Quaternion rot, Transform parent = null)
        {
            return PoolManager.Pools[PoolConstant.PoolItem].Spawn(prefab, pos, rot, parent);
        }

        public static Transform SpawnItem(string name, Vector3 pos, Quaternion rot, Transform parent = null)
        {
            return PoolManager.Pools[PoolConstant.PoolItem].Spawn(name, pos, rot, parent);
        }

        public static Transform SpawnItem(Transform prefab, Transform parent = null)
        {
            return PoolManager.Pools[PoolConstant.PoolItem].Spawn(prefab, parent);
        }

        public static Transform SpawnItem(string name, Transform parent = null)
        {
            return PoolManager.Pools[PoolConstant.PoolItem].Spawn(name, parent);
        }

        public static void DeSpawnFX(Transform trans)
        {
            PoolManager.Pools[PoolConstant.PoolParticle].Despawn(trans);
        }

        public static void DeSpawnItem(Transform trans)
        {
            PoolManager.Pools[PoolConstant.PoolItem].Despawn(trans);
        }

        public static void DeSpawnEnemy(Transform trans)
        {
            PoolManager.Pools[PoolConstant.PoolEnemy].Despawn(trans);
        }

        public static void DeSpawnFX(GameObject trans)
        {
            PoolManager.Pools[PoolConstant.PoolParticle].Despawn(trans.transform);
        }

        public static void DeSpawnItem(GameObject trans)
        {
            PoolManager.Pools[PoolConstant.PoolItem].Despawn(trans.transform);
        }

        public static void DeSpawnEnemy(GameObject trans)
        {
            PoolManager.Pools[PoolConstant.PoolEnemy].Despawn(trans.transform);
        }
    }
}