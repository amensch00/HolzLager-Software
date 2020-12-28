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
	class PacketeViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		
		public Visibility IsVisible { get; set; }
		
		public RelayCommand CMD_editPackage { get => new RelayCommand(editPackage, true); }
		public RelayCommand CMD_delPackage { get => new RelayCommand(delPackage, true); }
		public RelayCommand CMD_addPackage { get => new RelayCommand(addPackage, true); }
		public RelayCommand CMD_createReportFromFilter { get => new RelayCommand(createReportFromFilter, true); }
		public RelayCommand CMD_applyFilter { get => new RelayCommand(applyFilter, true); }
		
		private void editPackage()
		{
			
		}

		private void delPackage()
		{
			
		}

		private void addPackage()
		{
			
		}

		private void createReportFromFilter()
		{
			
		}

		private void applyFilter()
		{
			
		}
	}
}
