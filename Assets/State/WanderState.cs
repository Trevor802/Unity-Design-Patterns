using UnityEngine;

namespace StatePattern
{
    public class WanderState : State
    {
        private Vector3 destination;
        private float wanderTime = 5;
        private float wanderTimer;

        public WanderState(Character character) : base(character)
        {
            stateName = "wandering";
        }

        public override void Tick()
        {
            if (character.ReachedDestination(destination))
                RandomizeDestination();
            character.MoveToward(destination);
            wanderTimer += Time.deltaTime;
            if (wanderTimer > wanderTime)
            {
                wanderTimer = 0;
                character.SetState(new IdleState(character));
            }
        }

        private void RandomizeDestination()
        {
            destination = new Vector3(
                Random.Range(-5, 5),
                0,
                Random.Range(-5, 5));
        }
    }
}