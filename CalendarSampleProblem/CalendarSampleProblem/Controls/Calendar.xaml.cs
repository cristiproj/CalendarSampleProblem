using CalendarSampleProblem.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalendarSampleProblem.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calendar : ContentView
    {
        public static readonly BindableProperty AppointmentsDataProperty = BindableProperty.Create(nameof(AppointmentsData), typeof(CalendarControlModel), typeof(Calendar), new CalendarControlModel(),
            propertyChanged: (bindableObject, oldValue, newValue) =>
            {
                if (bindableObject is Calendar view)
                {
                    view.AppointmentsData = (CalendarControlModel)newValue;
                }
            });

        public CalendarControlModel AppointmentsData
        {
            get => (CalendarControlModel)GetValue(AppointmentsDataProperty);
            set
            {
                SetValue(AppointmentsDataProperty, value);
                PrepareAppointments();
            }
        }

        public Calendar()
        {
            InitializeComponent();
        }

        private void PrepareAppointments()
        {
            //just to add dynamic controls as an example
            var label = new Label {Text = $"{AppointmentsData.Hour}:{AppointmentsData.Minute}", HorizontalTextAlignment = TextAlignment.Center, FontSize = 32};

            MainScrollView.Content = label;
        }
    }
}