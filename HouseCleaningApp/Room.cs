using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HouseCleaningApp
{
    // Room class to represent cleaning schedule propperties
    public class Room : INotifyPropertyChanged // Notifies UI about property changes with edit and current pages
    {
        public string name { get; set; }
        public DateTime lastCleaned { get; set; }
        public DateTime nextClean { get; set; }

        public string Name 
        { 
            get => name; // Getter returns the current value of name
            set
            {
                if(name != value) // If the new value is different from the current value
                {
                    name = value; // Update the field with the new value
                    OnPropertyChanged(); // Let UI know that property changed
                }
            }
        }
        public DateTime LastCleaned 
        { 
            get => lastCleaned; // Getter returns the current value of lastCleaned
            set
            {
                if(lastCleaned != value) // If the new value is different from the current value
                {
                    lastCleaned = value; // Update the field with the new value
                    OnPropertyChanged(); // Let UI know that property changed
                }
            }
        }
        public DateTime NextClean 
        { 
            get => nextClean; // Getter returns the current value of nextClean
            set
            {
                if(nextClean != value) // If the new value is different from the current value               
                {
                    nextClean = value; // Update the field with the new value
                    OnPropertyChanged(); // Let UI know that property changed
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged; // Event that is triggered when a property value changes

        // Method to raise the PropertyChanged event
        // [] attribute allows the caller's name to be automatically supplied as the property name
        public void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            // If there are any subscribers to the PropertyChanged event, invoke the event
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
