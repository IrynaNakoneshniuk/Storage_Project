using Storage_Project.Model;
using Storage_Project.View;
using Storage_Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Storage_Project.Commands
{
    public class SelectConnection : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public AddNewConnectVM connectPage;

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public SelectConnection(AddNewConnectVM newConnectPage)
        {
            this.connectPage = newConnectPage;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "Conect")
            {
                try
                {
                    ConnectionDBStorage.Connection = this.connectPage.ConnectionString;
                    ConnectionDBStorage.OpenConnection();
                    MessageBox.Show("Connect");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
