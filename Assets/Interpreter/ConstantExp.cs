using UnityEngine.Assertions;

namespace InterpreterPattern
{
    public class ConstantExp : BooleanExp
    {
        private string name;

        public ConstantExp(string name)
        {
            Assert.IsTrue(name == "true" || name == "false");
            this.name = name;
        }

        public override bool Evaluate(Context context)
        {
            return name == "true";
        }
    }
}