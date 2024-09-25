using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Rental : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }  // Foreign key
        public int CustomerId { get; set; }  // Foreign key
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }  // Nullable for unreturned cars

        public Car Cars { get; set; }
        public Customer Customers { get; set; }
    }

}