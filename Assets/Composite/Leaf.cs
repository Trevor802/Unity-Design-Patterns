using UnityEngine;
using System;

namespace CompositePattern
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name) { }

        public override void Display(int depth)
        {
            Debug.Log(new String('-', depth) + name);
        }

        public override void Add(Component component)
        {
            Debug.LogError("Leaf node cannot add component");
        }

        public override void Remove(Component component)
        {
            Debug.LogError("Leaf node cannot remove component");
        }
    }
}