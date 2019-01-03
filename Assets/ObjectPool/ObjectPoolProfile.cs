using UnityEngine;

namespace ObjectPool
{
    [CreateAssetMenu(menuName = "ObjectPool/Pool Profile")]
    public class ObjectPoolProfile : ScriptableObject
    {
        public string poolName;
        public GameObject prefab;
        public int size;
    }
}
