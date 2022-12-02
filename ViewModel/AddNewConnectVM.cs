using Storage_Project.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Storage_Project.ViewModel
{
    public class AddNewConnectVM:BaseViewModel
    {
        public ICommand AddConnection { get; set; }
        private string _connectionString;

        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value;
             OnPropertyChanged(nameof(ConnectionString));}
        }
        public AddNewConnectVM()
        {
            this.AddConnection = new SelectConnection(this);
        }
    }
}
