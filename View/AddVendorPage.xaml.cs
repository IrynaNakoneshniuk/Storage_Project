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
    /// Interaction logic for AddVendorPage.xaml
    /// </summary>
    public partial class AddVendorPage : UserControl
    {
        private AddVendorVM AddVendor;
        public AddVendorPage()
        {
            InitializeComponent();
            AddVendor = new AddVendorVM();
            this.DataContext = AddVendor;
        }
    }
}
