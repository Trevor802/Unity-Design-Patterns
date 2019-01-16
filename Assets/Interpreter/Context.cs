using System.Collections.Generic;
using UnityEngine.Assertions;

namespace InterpreterPattern
{
    public class Context
    {
        private Dictionary<string, bool> contexts = new Dictionary<string, bool>();

        public void Assign(VariableExp variable, bool state)
        {
            if (contexts.ContainsKey(variable.Name)) return;
            contexts.Add(variable.Name, state);
        }

        public bool LookUp(string name)
        {
            Assert.IsTrue(contexts.ContainsKey(name));
            return contexts[name];
        }
    }
}