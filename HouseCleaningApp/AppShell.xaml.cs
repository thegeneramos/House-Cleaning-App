using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
namespace HouseCleaningApp
{
    public partial class AppShell : Shell
    {
        // ObservableCollection to hold rooms and make accessible throughout the app
        // used instead of List to automatically update the UI when items are added or removed
        public static ObservableCollection<Room> Rooms { get; private set; } = new ObservableCollection<Room>();

        public AppShell()
        {
            InitializeComponent();
            // Register the routes to nativagate to different pages
            Routing.RegisterRoute(nameof(AddRoomPage), typeof(AddRoomPage)); // Route to AddRoomPage
            Routing.RegisterRoute(nameof(CurrentHomePage), typeof(CurrentHomePage)); // Route to CurrentHomePage
            Routing.RegisterRoute(nameof(EditRoomPage), typeof(EditRoomPage)); // Route to EditRoomPage
        }
    }
}
