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
    public class AddGoodCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public AddGoodsVM AddGoodsVM;
        public AddGoodCommand(AddGoodsVM addGoodsVM)
        {
            AddGoodsVM = addGoodsVM;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "goods")
            {
                try
                {
                    Good good = new Good(AddGoodsVM.Name, AddGoodsVM.Trademark,
                    AddGoodsVM.Category, AddGoodsVM.Amount, AddGoodsVM.Price, AddGoodsVM.Code);
                    AddGoodsVM.GoodsList.Add(good);
                    AddGoodsVM.Name = null;
                    AddGoodsVM.Trademark = null;
                    AddGoodsVM.Category = null;
                    AddGoodsVM.Amount = 0;
                    AddGoodsVM.Price = 0;
                    AddGoodsVM.Code = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }
    }
}
