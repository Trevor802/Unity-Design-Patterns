namespace InterpreterPattern
{
    public class VariableExp : BooleanExp
    {
        public string Name { get; }

        public VariableExp(string name) { Name = name; }

        public override bool Evaluate(Context context)
        {
            return context.LookUp(Name);
        }

        public override BooleanExp Replace(string name, BooleanExp exp)
        {
            if (name == Name) return exp.Copy();
            return new VariableExp(Name);
        }

        public override BooleanExp Copy()
        {
            return new VariableExp(Name);
        }
    }
}