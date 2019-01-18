using UnityEngine;

namespace MementoPattern
{
    public class Memento
    {
        public Vector3 Position { get; } // not restore gameobject's velocity

        public Memento(Vector3 position) { Position = position;}
    }
}

