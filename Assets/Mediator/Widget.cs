using UnityEngine;
using UnityEngine.Assertions;

namespace MediatorPattern
{
    public abstract class Widget : MonoBehaviour
    {
        public string Tag;

        protected Mediator mediator;

        protected abstract void InitializeWidget();

        protected void Awake()
        {
            mediator = GameObject.FindGameObjectWithTag(Tag).GetComponent<Mediator>();
            Assert.IsNotNull(mediator);
            InitializeWidget();
        }
    }
}