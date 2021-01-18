using Syncfusion.XForms.Buttons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleSample
{
    public class Model : INotifyPropertyChanged
    {
        private bool isChecked;

        private ICommand stateChangedCommand;
        public string Item { get; set; }
        public ICommand StateChangedCommand
        {
            get { return stateChangedCommand; }
            set
            {
                stateChangedCommand = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StateChangedCommand"));
            }
        }

        public bool IsChecked
        {
            get { return isChecked; }
            set
            {
                isChecked = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsChecked"));
            }
        }

        public Model()
        {
            StateChangedCommand = new Command(OutputValue);
        }

        void OutputValue(object person)
        {
            if (IsChecked)
            {
                App.Current.MainPage.DisplayAlert("Message", "Selected Language", (person as SfRadioButton).Text);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
