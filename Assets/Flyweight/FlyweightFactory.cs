using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern
{
    public class FlyweightFactory
    {
        private Dictionary<char, Flyweight> flyweights = 
            new Dictionary<char, Flyweight>();

        public Flyweight GetFlyweight(char key)
        {
            if (!flyweights.ContainsKey(key))
            {
                flyweights.Add(key, new ConcreteFlyweight(key));
            }
            else
            {
                flyweights[key] = new UnsharedConcreteFlyweight(key, 
                    Random.Range(0, 10), Random.Range(0 ,10));
            }
            return flyweights[key];
        }
    }
}