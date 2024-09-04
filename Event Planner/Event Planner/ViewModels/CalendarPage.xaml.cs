using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Event_Planner.Views
{
        public partial class CalendarPage : ContentPage
        {
            public CalendarPage()
            {
                InitializeComponent();

                BindingContext = new CalendarPageViewModel();
            }
        }

        public class CalendarPageViewModel
        {
            public ObservableCollection<Event> Events { get; set; }
            public Command AddEventCommand { get; }

            public CalendarPageViewModel()
            {
                Events = new ObservableCollection<Event>
            {
                new Event { EventName = "Meeting", EventDate = DateTime.Now.AddDays(1) },
                new Event { EventName = "Conference", EventDate = DateTime.Now.AddDays(2) }
            };

                AddEventCommand = new Command(AddEvent);
            }

            private async void AddEvent()
            {
                // Navigate to the Add Event Page
                await Application.Current.MainPage.Navigation.PushAsync(new AddEventPage());
            }
        }

        public class Event
        {
            public string EventName { get; set; }
            public DateTime EventDate { get; set; }
        }
    }

