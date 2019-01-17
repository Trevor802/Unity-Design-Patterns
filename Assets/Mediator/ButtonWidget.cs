using UnityEngine;
using UnityEngine.UI;

namespace MediatorPattern
{
    [RequireComponent(typeof(Button))]
    public class ButtonWidget : Widget
    {
        private Button button;

        protected override void InitializeWidget()
        {
            button = GetComponent<Button>();
            button.onClick.AddListener(delegate { mediator.WidgetChanged(this); });
        }
    }
}
