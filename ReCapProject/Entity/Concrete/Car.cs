using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }  // Foreign key
        public int ColorId { get; set; }  // Foreign key
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

        public Brand Brands { get; set; }
        public Color Colors { get; set; }
        public ICollection<Rental> Rentals { get; set; }
    }
}