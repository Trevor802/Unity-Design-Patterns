using UnityEngine;

namespace StatePattern
{
    public class Character : MonoBehaviour
    {
        private State state;
        private string initName;

        private void Awake()
        {
            initName = name;
            SetState(new IdleState(this));
        }

        private void Update()
        {
            state.Tick();
        }

        public void SetState(State state)
        {
            if (this.state != null)
                this.state.OnStateExit();
            this.state = state;
            name = initName + " State: " + state.GetName();
            if (state != null)
                state.OnStateEnter();
        }

        public void MoveToward(Vector3 destination)
        {
            transform.position = Vector3.MoveTowards(transform.position,
                destination, Time.deltaTime);
        }

        public bool ReachedDestination(Vector3 destination)
        {
            return Vector3.Distance(transform.position, destination) < 0.5f;
        }
    }
}

