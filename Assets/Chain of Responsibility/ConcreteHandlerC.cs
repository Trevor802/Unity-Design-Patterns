using UnityEngine;

namespace ChainPattern
{
    public class ConcreteHandlerC : HelpHandler
    {
        public ConcreteHandlerC(HelpHandler successor) : base(successor)
        {
        }

        public override void HandleRequest(int request)
        {
            if (HasHelp(request))
            {
                Debug.Log("Handler C handles request " + request);
            }
            else
            {
                successor?.HandleRequest(request);
            }
        }

        protected override bool HasHelp(int request)
        {
            return request >= 100;
        }
    }
}