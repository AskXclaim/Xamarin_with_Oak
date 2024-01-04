using Xamarin.Forms;

namespace XamarinElements.Shared
{
    public class StackLayoutCall
    {
        public Color? BackGroundColor { get; }
        public Thickness? Padding { get; }
        public LayoutOptions? HorizontalLayout { get; }
        public LayoutOptions? VerticalLayout { get; }
        public StackLayoutCall(
            Color? backGroundColor = null, Thickness? padding = null,
            LayoutOptions? horizontalLayout = null, LayoutOptions? verticalLayout = null)
        {
            BackGroundColor = backGroundColor ?? Color.FromHex("#177E89");
            Padding = padding;
            HorizontalLayout = horizontalLayout;
            VerticalLayout = verticalLayout;
        }
    }
}

