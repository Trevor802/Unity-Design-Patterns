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
    }
}