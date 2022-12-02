using Storage_Project.Model;
using Storage_Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Storage_Project.View
{
    /// <summary>
    /// Interaction logic for EditVendorPage.xaml
    /// </summary>
    public partial class EditVendorPage : UserControl
    {
        public EditVendorVM editVendorVM;
        public EditVendorPage()
        {
            InitializeComponent();
            editVendorVM = new EditVendorVM();
            editVendorVM.ListVendors = ConnectionDBStorage.GetVendorList();
            this.DataContext = editVendorVM;
        }
    }
}
