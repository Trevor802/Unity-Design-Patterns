using UnityEngine;

namespace ObserverPattern
{
    public class ConcreteObserverA : Observer
    {
        // Observer can observe multiple subjects
        private IntSubject iS;
        private BoolSubject bS;

        public ConcreteObserverA(IntSubject iS, BoolSubject bS)
        {
            this.iS = iS;
            this.bS = bS;
        }

        public override void OnNotify(Subject subject)
        {
            // call function according to different subjects
            if (subject == iS) Debug.Log("int: " + iS.State);
            else if (subject == bS) Debug.Log("bool: " + bS.State);
        }
    }
}
