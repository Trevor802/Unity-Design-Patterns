using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectPool
{
    public class ObjectPoolManager : MonoBehaviour
    {
        #region Singleton
        public static ObjectPoolManager Instance;

        private void Awake()
        {
            if (Instance)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
        }
        #endregion

        public List<ObjectPoolProfile> poolProfiles;
        public Dictionary<string, Transform> poolHolders = 
            new Dictionary<string, Transform>();
        public Dictionary<string, Queue<GameObject>> pools = 
            new Dictionary<string, Queue<GameObject>>();

        private void Start()
        {
            SetUpPools();
        }

        private void SetUpPools()
        {
            foreach (var pool in poolProfiles)
            {
                var holder = new GameObject(pool.poolName).transform;
                poolHolders.Add(pool.poolName, holder);
                holder.SetParent(transform);
                Queue<GameObject> objectPool = new Queue<GameObject>();
                for (int i = 0; i < pool.size; i++)
                {
                    GameObject gameObject =
                        Instantiate(pool.prefab, poolHolders[pool.poolName]);
                    gameObject.SetActive(false);
                    gameObject.name = pool.poolName + "_" + i;
                    objectPool.Enqueue(gameObject);
                }
                pools.Add(pool.poolName, objectPool);
            }
        }

        public GameObject SpawnFromPool(string poolName,
            Vector3 position, Quaternion rotation)
        {
            if (!pools.ContainsKey(poolName))
            {
                Debug.LogWarning("Spawning from pools failed: Not found <color=red>" 
                    + poolName + "</color> pool.");
                return null;
            }
            GameObject gameObject = pools[poolName].Dequeue();
            gameObject.SetActive(true);
            gameObject.transform.position = position;
            gameObject.transform.rotation = rotation;
            gameObject.GetComponent<IPoolObject>()?.OnRespawn();
            pools[poolName].Enqueue(gameObject);
            return gameObject;
        }
    }
}
