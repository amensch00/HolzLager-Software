using System.ComponentModel;
using System.Windows;

namespace Holzlager.ViewModels
{
    public class SettingsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        public Visibility IsVisible { get; set; }
    }
}