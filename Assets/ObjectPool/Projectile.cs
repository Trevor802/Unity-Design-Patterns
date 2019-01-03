using UnityEngine;

namespace ObjectPool
{
    public class Projectile : MonoBehaviour, IPoolObject
    {
        public float upVelocity = 1f;
        public float sideVelocity = .1f;
        public void OnRespawn()
        {
            float xVelocity = Random.Range(-sideVelocity, sideVelocity);
            float zVelocity = Random.Range(-sideVelocity, sideVelocity);
            float yVelocity = Random.Range(upVelocity / 2f, upVelocity);
            GetComponent<Rigidbody>().velocity = 
                new Vector3(xVelocity, yVelocity, zVelocity);
        }
    }
}
