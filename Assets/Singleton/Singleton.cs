using UnityEngine;

namespace Singleton
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static bool shuttingDown = false;
        private static object locker = new object();
        private static T instance;

        public static T Instance
        {
            get
            {
                if (shuttingDown)
                {
                    Debug.LogWarning("[Singleton] Instance " + typeof(T) +
                        " already destroyed. Returning null.");
                    return null;
                }
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = (T)FindObjectOfType<T>();
                        if (instance == null)
                        {
                            var singleton = new GameObject(typeof(T).ToString());
                            instance = singleton.AddComponent<T>();
                            DontDestroyOnLoad(singleton);
                        }
                    }
                    return instance;
                }
            }
        }

        private void OnApplicationQuit()
        {
            shuttingDown = true;
        }

        private void OnDestroy()
        {
            shuttingDown = true;
        }
    }
}

