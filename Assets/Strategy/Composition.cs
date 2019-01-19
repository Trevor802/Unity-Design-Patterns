using UnityEngine;

namespace StrategyPattern
{
    public class Composition
    {
        protected Compositor compositor;

        public Composition(Compositor compositor)
        {
            this.compositor = compositor;
        }

        public void Operation()
        {
            Debug.Log(compositor.Compose());
        }
    }
}

