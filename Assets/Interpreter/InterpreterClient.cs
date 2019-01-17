using UnityEngine;
using InterpreterPattern;

public class InterpreterClient : MonoBehaviour
{
    private void OnEnable()
    {
        Context context = new Context();
        VariableExp x = new VariableExp("X");
        VariableExp y = new VariableExp("Y");
        BooleanExp expression = new OrExp(new AndExp(new ConstantExp("true"), x),
            new AndExp(y, new NotExp(x))); // (true and x) or (y and (not x))
        context.Assign(x, false);
        context.Assign(y, true);
        Debug.Log(expression.Evaluate(context));

        VariableExp z = new VariableExp("Z");
        NotExp notZ = new NotExp(z);
        context.Assign(z, true);
        Debug.Log(expression.Replace("Y", notZ).Evaluate(context));
    }
}
