namespace InterpreterPattern
{
    public class VariableExp : BooleanExp
    {
        public VariableExp(string name) { Name = name; }

        public string Name { get; }

        public override bool Evaluate(Context context)
        {
            return context.LookUp(Name);
        }
    }
}