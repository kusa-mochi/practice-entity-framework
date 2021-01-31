using Prism.Mvvm;
using Prism.Regions;

namespace PracticeEntiryFramework.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(Views.MainWindowContent));
            _regionManager.RequestNavigate("ContentRegion", "MainWindowContent");
        }

        private readonly IRegionManager _regionManager;
    }
}
