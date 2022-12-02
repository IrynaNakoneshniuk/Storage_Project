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
    public class EditVendorVM:BaseViewModel
    {
        public ICommand editVendorCommand { get; set; } 
        private List<Vendor> _listVendors { get; set; }
        private int _index;
        public int Index
        {
            get { return _index; }
            set
            {
                _index = value;
                OnPropertyChanged(nameof(Index));
            }
        }
        public List<Vendor> ListVendors
        {
            get { return _listVendors; }
            set
            {
                if (_listVendors != null)
                {
                    _listVendors = value;
                    OnPropertyChanged(nameof(ListVendors));
                }
            }
        }
        public EditVendorVM()
        {
            _listVendors = new List<Vendor>();
            editVendorCommand = new EditVendorCommand(this);
          
        }
    }
}
