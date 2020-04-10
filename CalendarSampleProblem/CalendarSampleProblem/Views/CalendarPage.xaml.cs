using CalendarSampleProblem.Models;
using CalendarSampleProblem.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalendarSampleProblem.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarPage : ContentPage
    {
        public CalendarPage()
        {
            InitializeComponent();
            CalendarPageViewModel model = new CalendarPageViewModel
            {
                AppointmentsData = new CalendarControlModel { Hour = "00", Minute = "00"}
            };

            BindingContext = model;
        }
    }
}