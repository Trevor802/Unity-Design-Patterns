using UnityEngine;

namespace StatePattern
{
    public class IdleState : State
    {
        private Vector3 destination = Vector3.zero;

        public IdleState(Character character) : base(character)
        {
            stateName = "returning";
        }

        public override void OnStateEnter()
        {
            character.GetComponent<Renderer>().material.color = Color.black;
        }

        public override void OnStateExit()
        {
            character.GetComponent<Renderer>().material.color = Color.red;
        }

        public override void Tick()
        {
            character.MoveToward(destination);
            if (character.ReachedDestination(destination))
                character.SetState(new WanderState(character));
        }
    }
}