using Storage_Project.Commands;
using Storage_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Storage_Project.ViewModel
{
    public class AddVendorVM:BaseViewModel
    {
        public ICommand AddVendorCommand { get; set; }
        public ICommand SaveVendorCommand { get; set; }
        public List<Vendor> vendors;
        private string _vendorName;
        private string _vendorTrademark;
        public string VendorName
        {
            get { return _vendorName; }
            set
            {
                _vendorName = value;
                OnPropertyChanged(nameof(VendorName));
            }
        }

        public string VendorTrademark
        {
            get { return _vendorTrademark; }
            set {
                _vendorTrademark = value; 
            OnPropertyChanged(nameof(VendorTrademark));}
        }
        public AddVendorVM()
        {
            vendors=new List<Vendor>();
            AddVendorCommand = new AddVendorCommand(this);
            SaveVendorCommand = new SaveVendorCommand(this);
        }
    }
}
