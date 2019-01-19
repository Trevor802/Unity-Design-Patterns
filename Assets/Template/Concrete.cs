using UnityEngine;

namespace TemplatePattern
{
    public class Concrete1 : Abstract
    {
        protected override void HookOperation()
        {
            Debug.Log("Concrete 1");
        }
    }

    public class Concrete2 : Abstract
    {
        protected override void HookOperation()
        {
            Debug.Log("Concrete 2");
        }
    }
}