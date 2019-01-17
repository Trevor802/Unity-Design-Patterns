using UnityEngine;

namespace MediatorPattern
{
    public abstract class Mediator : MonoBehaviour
    {
        public abstract void WidgetChanged(Widget widget);
    }
}