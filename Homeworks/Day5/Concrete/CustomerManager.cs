using Day5.Abstract;
using Day5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.Concrete
{
    internal class CustomerManager : ICustomerService, IMernisService
    {

        public void Add(Customer customer)
        {
            if (CheckIfRealPerson(customer))
                Console.WriteLine("Welcome to the Steam! -> " + customer.firstName + " " + customer.lastName);
            else Console.WriteLine("The person doesn't exist!");
        }

        public void Remove(Customer customer)
        {
            Console.WriteLine("I hope we meet again! -> " + customer.firstName + " " + customer.lastName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("The user is updated! -> " + customer.firstName + " " + customer.lastName);
        }

        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
