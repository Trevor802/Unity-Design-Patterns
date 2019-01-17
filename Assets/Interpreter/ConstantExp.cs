using UnityEngine.Assertions;

namespace InterpreterPattern
{
    public class ConstantExp : BooleanExp
    {
        public string Name { get; }

        public ConstantExp(string name)
        {
            Assert.IsTrue(name == "true" || name == "false");
            Name = name;
        }

        public override bool Evaluate(Context context)
        {
            return Name == "true";
        }

        public override BooleanExp Replace(string name, BooleanExp exp)
        {
            if (name == Name) return exp.Copy();
            return new ConstantExp(Name);
        }

        public override BooleanExp Copy()
        {
            return new ConstantExp(Name);
        }
    }
}