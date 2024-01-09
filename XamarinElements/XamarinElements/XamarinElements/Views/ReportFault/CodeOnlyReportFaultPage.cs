using System;

using Xamarin.Forms;

namespace XamarinElements.Views.ReportFault
{
    public class CodeOnlyReportFaultPage : CarouselPage
    {
        public Label BugReportedDateTime { get; set; }

        public CodeOnlyReportFaultPage()
        {
            BugReportedDateTime = GetLabel("Bug Date");
            Title = "Report faults";
            Children.Add(Shared.Elements.GetContentPage
                ("Report Bug", "", GetStackLayout()));

        }

        private StackLayout GetStackLayout() =>
        new StackLayout()
        {
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.StartAndExpand,
            Children = {GetLabel("Select the date you found the bug:"),
                GetEventAddedDatePicker(),GetEventAddedTimePicker(), BugReportedDateTime }
        };

        private Label GetLabel(string text) => new Label()
        {
            Text = text
        };

        private DatePicker GetEventAddedDatePicker()
        {
            var bugDatePicker = Shared.Elements.GetDatePicker(-1);
            bugDatePicker.DateSelected += (s, e) =>
            {
                OnSelectedDateForBug(s, e);
            };
            return bugDatePicker;
        }

        void OnSelectedDateForBug(object sender, DateChangedEventArgs e)
        {
            var split = BugReportedDateTime.Text.Split('@');
            BugReportedDateTime.Text = ((DatePicker)sender).Date.ToShortDateString();
            BugReportedDateTime.Text = $"{BugReportedDateTime.Text} @ {split[1]}";
        }

        private TimePicker GetEventAddedTimePicker()
        {
            var bugTimePicker = Shared.Elements.GetTimePicker();
           // BugReportedDateTime.Text = $"{BugReportedDateTime.Text} @ {bugTimePicker.Time}";
            bugTimePicker.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == "Time")
                {
                    var time = ((TimePicker)s).Time;
                    BugReportedDateTime.Text = $"{BugReportedDateTime.Text} @ {time}";
                }
            };

            return bugTimePicker;
        }

        private string GetDatePart() =>
            string.IsNullOrWhiteSpace(BugReportedDateTime.Text)
            || BugReportedDateTime.Text=="Bug Date" ? "---" : BugReportedDateTime.Text;


        /* private Label GetBoundedLabel(object bindingContext)
         {
             var label = GetLabel();

             var binding = new Binding("Date");
             binding.Source = bindingContext;
             // label.BindingContext = bindingContext;
             label.SetBinding(Label.TextProperty, binding);

             return label;
         } */
    }
}


