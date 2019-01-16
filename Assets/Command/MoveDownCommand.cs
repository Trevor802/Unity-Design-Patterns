using UnityEngine;

namespace CommandPattern
{
    public class MoveDownCommand : MoveCommand
    {
        public MoveDownCommand(Transform target) : 
            base(target, new Vector3(target.position.x, 
                target.position.y, target.position.z - 1))
        {
        }
    }
}