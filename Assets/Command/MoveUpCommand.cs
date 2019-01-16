using UnityEngine;

namespace CommandPattern
{
    public class MoveUpCommand : MoveCommand
    {
        public MoveUpCommand(Transform target) : 
            base(target, new Vector3(target.position.x, 
                target.position.y, target.position.z + 1))
        {
        }
    }
}