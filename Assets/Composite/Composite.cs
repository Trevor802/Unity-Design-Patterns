using System.Collections.Generic;
using UnityEngine;
using System;

namespace CompositePattern
{
    public class Composite : Component
    {
        private List<Component> components = new List<Component>();

        public Composite(string name) : base(name) { }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override void Display(int depth)
        {
            Debug.Log(new String('-', depth) + name);
            foreach (var component in components)
            {
                component.Display(depth + 1);
            }
        }
    }
}