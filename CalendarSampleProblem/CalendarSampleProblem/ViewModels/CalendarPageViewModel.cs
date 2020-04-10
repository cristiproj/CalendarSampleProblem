using System;
using System.Windows.Input;
using CalendarSampleProblem.Models;
using Xamarin.Forms;

namespace CalendarSampleProblem.ViewModels
{
    class CalendarPageViewModel : BaseViewModel
    {
        private CalendarControlModel appointmentsData;

        public ICommand NewTimeCommand { get; set; }

        public CalendarControlModel AppointmentsData
        {
            get => appointmentsData;
            set => SetProperty(ref appointmentsData, value);
        }

        public CalendarPageViewModel()
        {
            NewTimeCommand = new Command(() => AppointmentsData = new CalendarControlModel { Hour = $"{DateTime.Now.Hour}", Minute = $"{DateTime.Now.Minute}" });
        }
    }
}
