using Day5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.Abstract
{
    internal interface ICustomerService
    {
        public void Add(Customer customer);
        public void Update(Customer customer);
        public void Remove(Customer customer);
    }
}
