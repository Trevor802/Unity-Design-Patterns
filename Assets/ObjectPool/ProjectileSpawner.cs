using UnityEngine;

namespace ObjectPool
{
    public class ProjectileSpawner : MonoBehaviour
    {
        public ObjectPoolProfile poolProfile;
        private void FixedUpdate()
        {
            ObjectPoolManager.Instance.SpawnFromPool(poolProfile.poolName,
                transform.position, Quaternion.identity);
        }
    }
}
