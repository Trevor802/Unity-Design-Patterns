using UnityEngine;

namespace ObjectPool
{
    [CreateAssetMenu(menuName = "Profile/Pool Profile")]
    public class ObjectPoolProfile : ScriptableObject
    {
        public string poolName;
        public GameObject prefab;
        public int size;
    }
}
