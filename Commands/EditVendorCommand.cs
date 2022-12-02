using Storage_Project.Model;
using Storage_Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Storage_Project.Commands
{
    public class EditVendorCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private MaineViewModel viewModel;

        public EditVendorVM editVendorVM;
        public AddVendorVM AddVendorVM;
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public EditVendorCommand(EditVendorVM editVendorVM)
        {
            this.editVendorVM = editVendorVM;
        }
        public void Execute(object parameter)
        {
            AddVendorVM=new AddVendorVM();
            viewModel =new  MaineViewModel();
            AddVendorVM.vendors.Add(ConnectionDBStorage.GetVendor(editVendorVM.Index));
            viewModel.SelectedViewModel = AddVendorVM;
        }
    }
}
