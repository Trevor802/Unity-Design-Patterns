using UnityEngine;

namespace CommandPattern
{
    public class MoveCommand : Command
    {
        protected Vector3 positionAfter;
        protected Vector3 positionBefore;
        protected Transform target;

        public MoveCommand(Transform target, Vector3 to)
        {
            this.target = target;
            positionBefore = target.position;
            positionAfter = to;
        }

        public override void Execute()
        {
            target.position = positionAfter;
        }

        public override void Undo()
        {
            target.position = positionBefore;
        }
    }
}