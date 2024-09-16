using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace SimpleSample
{
    public class ViewModel : INotifyPropertyChanged
    {

        public List<Model> Items { get; set; }

        public ViewModel()
        {
            Items = new List<Model>()
            {
                new Model(){Item = "C#" , IsChecked = true},
                new Model(){Item = "C++" , IsChecked = false},
                new Model(){Item = "C" , IsChecked = false},
                new Model(){Item = "JAVA" , IsChecked = false},

            };

        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
