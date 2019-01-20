using UnityEngine;

namespace SubclassSandbox
{
    public abstract class Superclass
    {
        private GameObject gameObject;

        public Superclass(GameObject gameObject)
        {
            this.gameObject = gameObject;
        }

        public abstract void Activate();

        protected void ChangeColor(Color color)
        {
            gameObject.GetComponent<Renderer>().material.color = color;
        }

        protected void Scale(Vector3 size)
        {
            gameObject.transform.localScale = size;
        }

        protected void MoveToward(Vector3 direction)
        {
            gameObject.transform.Translate(direction.normalized);
        }
    }
}
