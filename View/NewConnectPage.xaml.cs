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
using Storage_Project.ViewModel;
using System.Configuration;
using System.ComponentModel;

namespace Storage_Project.View
{
    /// <summary>
    /// Interaction logic for NewConnectPage.xaml
    /// </summary>
    public partial class NewConnectPage : UserControl
    {
        private AddNewConnectVM connectVM;
        public NewConnectPage()
        {
            InitializeComponent();
            this.cbConnection.ItemsSource = ConfigurationManager.ConnectionStrings;
            connectVM = new AddNewConnectVM();
            this.DataContext = connectVM;
        }
    }
}
