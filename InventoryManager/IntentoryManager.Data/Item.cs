using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace IntentoryManager.Data
{
    public class Item : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name { get; set; }
    }
}
