namespace InterpreterPattern
{
    public abstract class BooleanExp
    {
        public abstract bool Evaluate(Context context);
        public abstract BooleanExp Replace(string name, BooleanExp exp);
        public abstract BooleanExp Copy();
    }
}