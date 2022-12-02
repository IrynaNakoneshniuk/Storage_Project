using Storage_Project.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Storage_Project.Model;
namespace Storage_Project.ViewModel
{
    public class AddGoodsVM : BaseViewModel
    {
        public ICommand AddGoods { get; set; }
        public ICommand SaveListOfGoods { get; set; }
        public List<Good> GoodsList;
        private string _name;
        private string _trademark;
        private double _price;
        private int _amount;
        private int _code;
        private string _category;


        public string Name
        {
            get { return _name; }
            set { _name = value;
            OnPropertyChanged(nameof(Name));}
        }
        public string Trademark
        {
            get { return _trademark; }
            set { _trademark = value;
            OnPropertyChanged(nameof(Trademark));}
        }
        
        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
                OnPropertyChanged(nameof(Price));
            }
        }
        public int Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }
        public int Code
        {
            get { return _code; }
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }
        public string Category
        {
            get { return _category; }
            set { _category= value;
            OnPropertyChanged(nameof(Category));}
        }

        public AddGoodsVM()
        {
            GoodsList = new List<Good>();
            this.AddGoods = new AddGoodCommand(this);
            this.SaveListOfGoods= new SaveGoodsCommand(this);
             
        }
    }
}
