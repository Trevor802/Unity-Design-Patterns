namespace InterpreterPattern
{
    public class NotExp : BooleanExp
    {
        private BooleanExp operand;

        public NotExp(BooleanExp op)
        {
            operand = op;
        }

        public override bool Evaluate(Context context)
        {
            return !operand.Evaluate(context);
        }

        public override BooleanExp Replace(string name, BooleanExp exp)
        {
            return new NotExp(operand.Replace(name, exp));
        }

        public override BooleanExp Copy()
        {
            return new NotExp(operand.Copy());
        }
    }
}