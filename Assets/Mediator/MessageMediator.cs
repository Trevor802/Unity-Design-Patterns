namespace MediatorPattern
{
    public class MessageMediator : Mediator
    {
        private InputFieldWidget inputField;
        private TextWidget text;
        private ButtonWidget button;

        private void Awake()
        {
            inputField = GetComponentInChildren<InputFieldWidget>();
            text = GetComponentInChildren<TextWidget>();
            button = GetComponentInChildren<ButtonWidget>();
        }

        public override void WidgetChanged(Widget widget)
        {
            if (widget == inputField)
            {
                text.SetText(inputField.GetText());
            }
            else if (widget == button)
            {
                inputField.SetText("");
                text.SetText("");
            }
        }
    }
}
