using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Project.Model
{
    public  class Vendor
    {
        public string  Name { get; set; }
        public string   Trademark { get; set; }
        public Vendor(string name, string trademark)
        {
            Name = name;
            Trademark = trademark;
        }

        public Vendor()
        {
        }
    }
}
