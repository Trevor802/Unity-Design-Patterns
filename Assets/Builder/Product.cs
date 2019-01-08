using System.Collections.Generic;
using UnityEngine;

namespace Builder
{
    public class Product
    {
        private List<string> parts = new List<string>();

        public void Add(string s)
        {
            parts.Add(s);
        }

        public void Show()
        {
            foreach (var part in parts)
            {
                Debug.Log(part);
            }
        }
    }
}

