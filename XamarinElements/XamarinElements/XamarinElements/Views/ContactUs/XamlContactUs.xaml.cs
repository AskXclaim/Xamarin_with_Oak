using System;
using System.Linq;
using Xamarin.Forms;

namespace XamarinElements.Views.ContactUs
{
    public partial class XamlContactUs : ContentPage
    {
        const float progressBarCalculationValue= 0.0333f;
        public XamlContactUs()
        {
            InitializeComponent();
            pbContactUsCharCount.Progress = contactUsMsgFontSizer.Value * progressBarCalculationValue;
        }

        void contactUsMessage_TextChanged(object sender, TextChangedEventArgs e)
        {
            var text = e.NewTextValue;
            var charactersLeft = 150;
            var message = "Characters left:";
            if (string.IsNullOrWhiteSpace(text))
            {
                contactUsMessage.Text = "";
                lblContactUsCharCount.Text = $"{message}{charactersLeft}";
                return;
            }

            charactersLeft -= text.ToCharArray().Length;
            message = $"{message}{charactersLeft}";
            lblContactUsCharCount.Text = message;

        }

        void contactUsSearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            var text = contactUsSearchBar.Text?.Trim();
            var contactMsg = contactUsMessage.Text?.ToLower();
            if (string.IsNullOrWhiteSpace(text) || string.IsNullOrWhiteSpace(contactMsg))
            {
                lblSearchBar.Text = "";
                return;
            }

            char[] separator = { '.', '?', '!', ' ', ';', ':', ',' };
            var message = contactMsg.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            var matches = message.Where(w => w.Contains(text.ToLower()));
            lblSearchBar.Text = $"Number of matches for {text}:{matches.Count()}";
        }

        void contactUsMoreOption_Toggled(object sender, ToggledEventArgs e)
        {
            contactUsPhoneStackLayout.IsVisible = e.Value;
        }

        void makeBoldContactUs_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value.Equals(true) && contactUsPhoneStackLayout.IsVisible)
                contactUsPhone.FontAttributes = FontAttributes.Bold;
            else
                contactUsPhone.FontAttributes = FontAttributes.None;
        }

        void contactUsEmailFontSizer_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            contactUsEmail.FontSize = e.NewValue;
        }

        void contactUsMsgFontSizer_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            pbContactUsCharCount.ProgressTo(e.NewValue * progressBarCalculationValue, 500, Easing.Linear);
        }
    }
}

