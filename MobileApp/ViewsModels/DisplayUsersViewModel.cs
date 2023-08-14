using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace MobileApp.ViewsModels
{
    public class DisplayUsersViewModel : INotifyPropertyChanged
    {
        string Username = string.Empty;

        public string EntryUserName
        {
            get => Username;
            set
            {
                if (Username == value)

                    return;

                Username = value;
                WhenPropertyChanges(nameof(Username));
                WhenPropertyChanges(nameof(EntryEmail));

            }
        }
        public string EntryEmail => $"Name Entered: {EntryUserName}";

        public event PropertyChangedEventHandler PropertyChanged;

        void WhenPropertyChanges(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

}
