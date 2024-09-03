using Day5.Abstract;
using Day5.Entities;

namespace Day5.Concrete
{
    internal class CustomerManager : ICustomerService
    {
        MernisManager mernisManager;
        public CustomerManager(MernisManager mernisManager)
        {
            this.mernisManager = mernisManager;
        }

        public void Add(Customer customer)
        {
            if (mernisManager.CheckIfRealPerson(customer))
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
    }
}
