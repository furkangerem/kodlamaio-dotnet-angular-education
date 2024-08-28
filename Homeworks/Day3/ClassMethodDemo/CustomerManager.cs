using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {
        public void addCustomer(Customer customer)
        {
            Console.WriteLine("Given " + customer.firstName + " " + customer.lastName + " " + customer.age + " is added succesfully!");
        }
        public void deleteCustomer(Customer customer)
        {
            Console.WriteLine("Given " + customer.firstName + " " + customer.lastName + " " + customer.age + " is deleted succesfully!");
        }

        public void getWholeCustomers(Customer[] customers)
        {
            int i = 1;
            foreach (Customer eachCustomer in customers)
            {
                Console.WriteLine(i + ". customer's info: " + eachCustomer.firstName + " " + eachCustomer.lastName + " " + eachCustomer.age);
                i++;
            }
        }
    }
}
