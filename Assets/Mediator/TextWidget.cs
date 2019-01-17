using UnityEngine;
using UnityEngine.UI;

namespace MediatorPattern
{
    [RequireComponent(typeof(Text))]
    public class TextWidget : Widget
    {
        private Text text;

        protected override void InitializeWidget()
        {
            text = GetComponent<Text>();
        }

        public void SetText(string text)
        {
            this.text.text = text;
        }
    }
}
