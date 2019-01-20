using UnityEngine;

namespace SubclassSandbox
{
    public class Subclass1 : Superclass
    {
        public Subclass1(GameObject gameObject) : base(gameObject)
        {
        }

        public override void Activate()
        {
            ChangeColor(Color.red);
            Scale(Vector3.one * 5);
        }
    }

    public class Subclass2 : Superclass
    {
        public Subclass2(GameObject gameObject) : base(gameObject)
        {
        }

        public override void Activate()
        {
            MoveToward(Vector3.right);
            ChangeColor(Color.blue);
        }
    }
}
