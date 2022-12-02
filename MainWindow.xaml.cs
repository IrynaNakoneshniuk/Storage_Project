using Storage_Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Storage_Project
{
    //using Storage_Project.ViewModel;
    //using Storage_Project.View;
 
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MaineViewModel maineViewModel;
        public MainWindow()
        {
            InitializeComponent();
            maineViewModel = new MaineViewModel();
            this.DataContext = maineViewModel;

        }
    }
}
