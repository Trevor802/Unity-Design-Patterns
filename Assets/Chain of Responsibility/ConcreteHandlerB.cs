using UnityEngine;

namespace ChainPattern
{
    public class ConcreteHandlerB : HelpHandler
    {
        public ConcreteHandlerB(HelpHandler successor) : base(successor)
        {
        }

        public override void HandleRequest(int request)
        {
            if (HasHelp(request))
            {
                Debug.Log("Handler B handles request " + request);
            }
            else
            {
                successor?.HandleRequest(request);
            }
        }

        protected override bool HasHelp(int request)
        {
            return request >= 10 && request < 100;
        }
    }
}