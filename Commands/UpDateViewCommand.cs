using Storage_Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Storage_Project
{
    public class UpDateViewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private MaineViewModel viewModel;

        public UpDateViewCommand(MaineViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() =="Connection")
            {
                viewModel.SelectedViewModel=new AddNewConnectVM();
            }
            else if (parameter.ToString() == "Goods")
            {
                viewModel.SelectedViewModel = new AddGoodsVM();
            }
            else if (parameter.ToString() == "Vendor")
            {
                viewModel.SelectedViewModel = new AddVendorVM();
            }
            else if(parameter.ToString()== "EditVendor")
            {
                viewModel.SelectedViewModel = new EditVendorVM();
            }
        }
    }
}
