using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int categoryId { get; set; }
        public int unitsInStock { get; set; }
        public double unitPrice { get; set; }
    }
}
