using Storage_Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Storage_Project.Model;

namespace Storage_Project.Commands
{
    public class AddVendorCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public AddVendorVM addVendorVM;
        public AddVendorCommand(AddVendorVM addVendorVM) { 
         this.addVendorVM = addVendorVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "vendor")
            {
                Vendor vendor = new Vendor(addVendorVM.VendorName, addVendorVM.VendorTrademark);
                addVendorVM.vendors.Add(vendor);
                addVendorVM.VendorName = null; addVendorVM.VendorTrademark=null;
            }
        }
    }
}
