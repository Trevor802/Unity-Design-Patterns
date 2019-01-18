using UnityEngine;

namespace MementoPattern
{
    public class Originator : MonoBehaviour
    {
        public float ResetFrequency = 2f;

        private Caretaker caretaker;

        public Memento CreateMemento()
        {
            return new Memento(transform.position);
        }

        public void SetMemento(Memento memento)
        {
            transform.position = memento.Position;
        }

        private void Start()
        {
            caretaker = new Caretaker();
            caretaker.Memento = CreateMemento();
            InvokeRepeating("ResetPosition", ResetFrequency, ResetFrequency);
        }

        private void ResetPosition()
        {
            SetMemento(caretaker.Memento);
        }
    }
}