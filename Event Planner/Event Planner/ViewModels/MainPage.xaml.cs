using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


// Name: Adedeji Tiamiyu
//Date: November 16, 2022
//Description: Lab 5 Event Planner Application
//Subject: C# Programming

namespace Event_Planner.Views

{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel();
        }
    }

    public class MainPageViewModel
    {
        public Command NavigateToCalendarCommand { get; }

        public MainPageViewModel()
        {
            NavigateToCalendarCommand = new Command(NavigateToCalendar);
        }

        private async void NavigateToCalendar()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CalendarPage());
        }
    }
}
