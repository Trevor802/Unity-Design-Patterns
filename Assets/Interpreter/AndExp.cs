namespace InterpreterPattern
{
    public class AndExp : BooleanExp
    {
        private BooleanExp operand1;
        private BooleanExp operand2;

        public AndExp(BooleanExp op1, BooleanExp op2)
        {
            operand1 = op1;
            operand2 = op2;
        }

        public override bool Evaluate(Context context)
        {
            return operand1.Evaluate(context) && operand2.Evaluate(context);
        }

        public override BooleanExp Replace(string name, BooleanExp exp)
        {
            return new AndExp(operand1.Replace(name, exp),
                            operand2.Replace(name, exp));
        }

        public override BooleanExp Copy()
        {
            return new AndExp(operand1.Copy(), operand2.Copy());
        }
    }
}