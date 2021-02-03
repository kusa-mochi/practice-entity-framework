using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;

namespace PracticeEntiryFramework.ViewModels
{
    public class MainWindowContentViewModel : BindableBase
    {
        public MainWindowContentViewModel()
        {
            ComboBoxItems = new ObservableCollection<long> { 100L, 200L, 300L };
        }

        private int _ComboBoxSelectedIndex = -1;
        public int ComboBoxSelectedIndex
        {
            get { return _ComboBoxSelectedIndex; }
            set { SetProperty(ref _ComboBoxSelectedIndex, value); }
        }

        private ObservableCollection<long> _ComboBoxItems = null;
        public ObservableCollection<long> ComboBoxItems
        {
            get { return _ComboBoxItems; }
            set { SetProperty(ref _ComboBoxItems, value); }
        }

        private DelegateCommand _ResetCommand   ;
        public DelegateCommand ResetCommand =>
            _ResetCommand ?? (_ResetCommand = new DelegateCommand(ExecuteResetCommand));

        void ExecuteResetCommand()
        {
            ComboBoxSelectedIndex = -1;
        }
    }
}
