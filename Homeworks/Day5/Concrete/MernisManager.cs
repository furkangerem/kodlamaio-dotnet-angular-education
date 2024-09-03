using Day5.Abstract;
using Day5.Entities;

namespace Day5.Concrete
{
    internal class MernisManager : IMernisService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            if (customer.firstName == "Furkan" && customer.lastName == "Gerem" && customer.yearOfBirth == 1998 && customer.identityNumber == 11111111111)
                return true;
            else
                return false;
        }
    }
}
