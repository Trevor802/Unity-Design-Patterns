using UnityEngine;

namespace ProxyPattern
{
    public class RealSubject : Subject
    {
        public override void Request()
        {
            Debug.Log("Real object requests");
        }
    }
}