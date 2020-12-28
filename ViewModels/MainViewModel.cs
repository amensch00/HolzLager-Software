using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Holzlager.Backend;

namespace Holzlager.ViewModels
{
	class MainViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public Visibility IsVisible { get; set; }
		
		public RelayCommand CMD_PacketOverview { get => new RelayCommand(showPacketeOverview, true);}
		public RelayCommand CMD_CreateReport { get => new RelayCommand(showReports, true); }
		public RelayCommand CMD_AddPacket { get => new RelayCommand(showAddPackage, true);}
		public RelayCommand CMD_Holzzuschnitt { get => new RelayCommand(showHolzzuschnitt, true);}

		private AddPackageViewModel AddPackageViewModel;
		private HolzzuschnittViewModel HolzzuschnittViewModel;
		private PacketeViewModel PacketeViewModel;
		private ReportViewModel ReportViewModel;
		private SettingsViewModel _settingsViewModel;

		public MainViewModel(AddPackageViewModel ad, HolzzuschnittViewModel hv, PacketeViewModel pa, ReportViewModel rp, SettingsViewModel sv)
		{
			AddPackageViewModel = ad;
			HolzzuschnittViewModel = hv;
			PacketeViewModel = pa;
			ReportViewModel = rp;
			_settingsViewModel = sv;
			
			IsVisible = Visibility.Visible;
			
			AddPackageViewModel.IsVisible = Visibility.Hidden;
			HolzzuschnittViewModel.IsVisible = Visibility.Hidden;
			PacketeViewModel.IsVisible = Visibility.Hidden;
			ReportViewModel.IsVisible = Visibility.Hidden;
			_settingsViewModel.IsVisible = Visibility.Hidden;
		}

		private void showPacketeOverview()
		{
			IsVisible = Visibility.Hidden;
			
			AddPackageViewModel.IsVisible = Visibility.Hidden;
			HolzzuschnittViewModel.IsVisible = Visibility.Hidden;
			PacketeViewModel.IsVisible = Visibility.Visible;
			ReportViewModel.IsVisible = Visibility.Hidden;
		}

		private void showAddPackage()
		{
			IsVisible = Visibility.Hidden;
			
			AddPackageViewModel.IsVisible = Visibility.Visible;
			HolzzuschnittViewModel.IsVisible = Visibility.Hidden;
			PacketeViewModel.IsVisible = Visibility.Hidden;
			ReportViewModel.IsVisible = Visibility.Hidden;
		}

		private void showHolzzuschnitt()
		{
			IsVisible = Visibility.Hidden;
			
			AddPackageViewModel.IsVisible = Visibility.Hidden;
			HolzzuschnittViewModel.IsVisible = Visibility.Visible;
			PacketeViewModel.IsVisible = Visibility.Hidden;
			ReportViewModel.IsVisible = Visibility.Hidden;
		}

		private void showReports()
		{
			IsVisible = Visibility.Hidden;
			
			AddPackageViewModel.IsVisible = Visibility.Hidden;
			HolzzuschnittViewModel.IsVisible = Visibility.Hidden;
			PacketeViewModel.IsVisible = Visibility.Hidden;
			ReportViewModel.IsVisible = Visibility.Visible;
		}

		private void showSettings()
		{
			IsVisible = Visibility.Hidden;
			
			
		}
	}
}
