using System;
using System.Collections.Generic;
using System.Text;

namespace Event_Planner.Views
{
        public partial class AddEventPage : ContentPage
        {
            public AddEventPage()
            {
                InitializeComponent();

                BindingContext = new AddEventPageViewModel();
            }
        }

        public class AddEventPageViewModel
        {
            public string EventName { get; set; }
            public DateTime EventDate { get; set; }
            public string Notes { get; set; }

            public Command SaveEventCommand { get; }

            public AddEventPageViewModel()
            {
                EventDate = DateTime.Now;
                SaveEventCommand = new Command(SaveEvent);
            }

            private async void SaveEvent()
            {
                // Save event logic here

                await Application.Current.MainPage.Navigation.PopAsync();
            }
        }
    }

