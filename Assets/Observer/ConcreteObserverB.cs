using UnityEngine;

namespace ObserverPattern
{
    public class ConcreteObserverB : Observer
    {
        private IntSubject iS;
        private BoolSubject bS;
        private FloatSubject fS;

        public ConcreteObserverB(IntSubject iS, BoolSubject bS, FloatSubject fS)
        {
            this.iS = iS;
            this.bS = bS;
            this.fS = fS;
        }

        public override void OnNotify(Subject subject)
        {
            if (subject == iS) Debug.Log("int: " + iS.State);
            else if (subject == bS) Debug.Log("bool: " + bS.State);
            else if (subject == fS) Debug.Log("float: " + fS.State);
        }
    }
}
