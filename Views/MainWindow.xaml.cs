using Holzlager.ViewModels;

namespace Holzlager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private MainViewModel _mainViewModel;
        private AddPackageViewModel _addPackageViewModel;
        private HolzzuschnittViewModel _holzzuschnittViewModel;
        private PacketeViewModel _packeteViewModel;
        private ReportViewModel _reportViewModel;
        private SettingsViewModel _settingsViewModel;
        
        public MainWindow()
        {
            InitializeComponent();

            _addPackageViewModel = new AddPackageViewModel();
            _holzzuschnittViewModel = new HolzzuschnittViewModel();
            _packeteViewModel = new PacketeViewModel();
            _reportViewModel = new ReportViewModel();
            _settingsViewModel = new SettingsViewModel();
            
            _mainViewModel = new MainViewModel(_addPackageViewModel, _holzzuschnittViewModel, _packeteViewModel, _reportViewModel, _settingsViewModel);

            GRD_Menu.DataContext = _mainViewModel;
            GRD_AddPackage.DataContext = _addPackageViewModel;
            GRD_NeededHolzzuschnitt.DataContext = _holzzuschnittViewModel;
            GRD_PacketeUebersicht.DataContext = _packeteViewModel;
            GRD_CreateReport.DataContext = _reportViewModel;
            GRD_Settings.DataContext = _settingsViewModel;
        }
    }
}