using Day5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.Abstract
{
    internal interface IMernisService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
