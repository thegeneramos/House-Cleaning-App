using System;
using Microsoft.Maui.Controls;

namespace HouseCleaningApp
{
	public partial class EditRoomPage : ContentPage
	{
		private Room _room; // Private field to hold the room being edited

		public EditRoomPage(Room room) // Constructor to initialize the page with the selected room
		{
			InitializeComponent();
			_room = room; // Set private field to the selected room
			BindingContext = _room; // Bind the UI to the room's data
		}
		async void OnSaveButtonClicked(object sender, EventArgs e) // Save button event handler
		{
			_room.Name = RoomNameEntry.Text; // Update the room name
			_room.LastCleaned = LastCleanedDatePicker.Date; // Update the last cleaned date
			_room.NextClean = NextCleanedDatePicker.Date; // Update the next clean date

			await Navigation.PopAsync(); // Navigate back to the previous page
		}
		async void OnDeleteButtonClicked(object sender, EventArgs e) // Delete button event handler
		{
			AppShell.Rooms.Remove(_room); // Remove that room from the ObverableCollection in AppShell
			await Navigation.PopAsync(); // Navigate back to the previous page
		}
	}
}