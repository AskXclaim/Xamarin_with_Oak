using Xamarin.Forms;

namespace XamarinElements.Shared
{
    public class LabelCall
    {
        public string Text { get; }
        public Color BackgroundColor { get; }
        public Color? TextColor { get; }
        public byte FontSize { get; }
        public LabelCall(string text, Color backgroundColor,
            Color? textColor = null, byte fontSize = 20)
        {
            Text = text;
            BackgroundColor = backgroundColor;
            TextColor = textColor;
            FontSize = fontSize;
        }
    }
}

