using Storage_Project.Model;
using Storage_Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Storage_Project.Commands
{
    public class SaveVendorCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public AddVendorVM addVendorVM;
        public SaveVendorCommand(AddVendorVM addVendorVM)
        {
            this.addVendorVM = addVendorVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "save")
            {
                ConnectionDBStorage.AddVendor(addVendorVM.vendors);
                MessageBox.Show("Saved!");
            }
        }
    }
}
