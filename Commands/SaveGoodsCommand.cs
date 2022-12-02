using Storage_Project.Model;
using Storage_Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Storage_Project.Commands
{
    public class SaveGoodsCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public AddGoodsVM addGoodsVM;

        public SaveGoodsCommand(AddGoodsVM addGoodsVM)
        {
            this.addGoodsVM = addGoodsVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "save")
            {
                ConnectionDBStorage.AddGoods(addGoodsVM.GoodsList);
                MessageBox.Show("Saved!");
            }
        }
    }
}
