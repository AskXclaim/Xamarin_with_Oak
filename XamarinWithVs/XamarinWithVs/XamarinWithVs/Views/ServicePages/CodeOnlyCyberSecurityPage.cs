using Xamarin.Forms;

namespace XamarinWithVs.Views.ServicePages
{
    public class CodeOnlyCyberSecurityPage : ContentPage
	{
		public CodeOnlyCyberSecurityPage ()
		{
			Content = new StackLayout {
				Children = {
                    Shared.SharedLabel.GetCenteredLabel("Cybersecurity services",null, 30),
                    Shared.SharedLabel.GetCenteredAndExpandedLabel("Let's help keep you safe!",null, 30)
				}
			};
		}
	}
}


