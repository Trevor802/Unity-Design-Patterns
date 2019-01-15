using UnityEngine;

namespace ChainPattern
{
    public class ConcreteHandlerA : HelpHandler
    {
        public ConcreteHandlerA(HelpHandler successor) : base(successor)
        {
        }

        public override void HandleRequest(int request)
        {
            if (HasHelp(request))
            {
                Debug.Log("Handler A handles request " + request);
            }
            else
            {
                successor?.HandleRequest(request);
            }
        }

        protected override bool HasHelp(int request)
        {
            return true;
        }
    }
}