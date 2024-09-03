using Day5.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.Entities
{
    internal class Customer
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int yearOfBirth { get; set; }
        public long identityNumber { get; set; }
    }
}
