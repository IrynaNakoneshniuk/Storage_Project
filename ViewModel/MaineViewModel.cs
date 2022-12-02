using Storage_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Storage_Project.ViewModel
{
    public class MaineViewModel:BaseViewModel
    {
        private BaseViewModel _selectedViewModel;
    

        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set { _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }
        public ICommand UpDateViewCommand { get; set; }
            public MaineViewModel() {
            UpDateViewCommand = new UpDateViewCommand(this);
            }
    }
}
