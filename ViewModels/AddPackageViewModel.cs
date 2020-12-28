using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Holzlager.Backend;

namespace Holzlager.ViewModels
{
	class AddPackageViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public Visibility IsVisible { get; set; }
		
		public DataTable AddPackagesTable { get; set; }
		
		public string Holztyp { get; set; }
		public int PacketNr { get; set; }
		public string Holzherkunft { get; set; }
		public int Jahr { get; set; }
		public int Holzlaenge { get; set; }
		public int Holzdicke { get; set; }
		public double Breitenmeter { get; set; }

		public RelayCommand CMD_EditPackage { get => new RelayCommand(editPackage, true); }
		public RelayCommand CMD_DelPackage { get => new RelayCommand(delPackage, true); }
		public RelayCommand CMD_addPackageToList { get => new RelayCommand(addPackageToList, true); }
		public RelayCommand CMD_BurnListToDB { get => new RelayCommand(burnListToDB, true); }

		private void editPackage()
		{
			
		}

		private void delPackage()
		{
			
		}

		private void addPackageToList()
		{
			AddPackagesTable.DataSet.
		}

		private void burnListToDB()
		{
			
		}
	}
}
