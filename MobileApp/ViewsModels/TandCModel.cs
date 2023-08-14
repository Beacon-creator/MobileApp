using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MobileApp.ViewsModels
{
    public class TandCModel : INotifyPropertyChanged
    {
        private bool isChecked;
        public bool IsChecked
        {
            get { return isChecked; }
            set
            {
                isChecked = value;
                OnPropertyChanged(nameof(IsChecked));
            }
        }

        private string labelText;
        public string LabelText
        {
            get { return labelText; }
            set
            {
                labelText = value;
                OnPropertyChanged(nameof(LabelText));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}