using UnityEngine;
using UnityEngine.UI;

namespace MediatorPattern
{
    [RequireComponent(typeof(InputField))]
    public class InputFieldWidget : Widget
    {
        private InputField inputField;

        protected override void InitializeWidget()
        {
            inputField = GetComponent<InputField>();
            inputField.onValueChanged.AddListener(delegate
            {
                mediator.WidgetChanged(this);
            });
        }

        public string GetText()
        {
            return inputField.text;
        }

        public void SetText(string text)
        {
            inputField.text = text;
        }
    }
}