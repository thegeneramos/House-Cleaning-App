using System.Collections.Generic;
using Microsoft.Maui.Controls;
using System;
using static HouseCleaningApp.AddRoomPage;

namespace HouseCleaningApp
{
	public partial class CurrentHomePage : ContentPage
	{
		public CurrentHomePage()
		{
			InitializeComponent();
			LoadHouse(); // Use the LoadHouse Method
        }
		// Override the OnAppearing method to refresh the data each time the page appears
        protected override void OnAppearing()
        {
            base.OnAppearing(); // Call the class's OnAppearing method
            LoadHouse(); // Refresh the data in the CollectionView
        }
        void LoadHouse() // Method to populate the Collectionview 
		{
			RoomsCollectionView.ItemsSource = null; // Clear the collection view so it updates correctly
			RoomsCollectionView.ItemsSource = AppShell.Rooms; // Set the CollectionView's ItemSource to updated room list
		}
		async void OnEditRoomButtonClicked(object sender, EventArgs e) // Edit Room button event handler
		{
			var button = sender as Button; // Get the button that was clicked
			var room = button.CommandParameter as Room; // Associate the room with the button
			if (room != null)
			{
				await Navigation.PushAsync(new EditRoomPage(room)); // Navigate to the EditRoomPage with the selected room
            }
		}
	}
}