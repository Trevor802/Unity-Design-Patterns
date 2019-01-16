using UnityEngine;

namespace CommandPattern
{
    public class MoveRightCommand : MoveCommand
    {
        public MoveRightCommand(Transform target) : 
            base(target, new Vector3(target.position.x + 1, 
                target.position.y, target.position.z))
        {
        }
    }
}