using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Storage_Project.Model
{
    public  class Good
    {

        public int _Id;

        public string _Name;

        public  string _Trademark;

        public string _Category;

        public int _Amount;

        public double _Price;

        public int _Code;

        public Good(string name, string trademark, string category, int amount, double price, int code)
        {
            _Name = name;
            _Trademark = trademark;
            _Category = category;
            _Amount = amount;
            _Price = price;
            _Code = code;
        }
    }
}
