
using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace HouseCleaningApp;

public partial class AddRoomPage : ContentPage
{
	public AddRoomPage()
	{
		InitializeComponent();
	}
    async void OnAddRoomButtonClicked(object sender, EventArgs e) // Add Room event handler
	{
		var room = new Room // Create room
		{
			Name = RoomNameEntry.Text, // Set room name
            LastCleaned = DateTime.Now, // Set last cleaned date to now
            NextClean = DateTime.Now.AddDays(7) // Set next clean in 7 days
        };
		AppShell.Rooms.Add(room); // Add the room to the ObservanleCollection in AppShell
		RoomNameEntry.Text = string.Empty; // Clear the room name field
        LastCleanedDatePicker.Date = DateTime.Now; // Set last clean date
        NextCleanedDatePicker.Date = DateTime.Now.AddDays(7); // Set next clean date

		await Navigation.PopAsync(); // Navigate to previous page
    }
	
}