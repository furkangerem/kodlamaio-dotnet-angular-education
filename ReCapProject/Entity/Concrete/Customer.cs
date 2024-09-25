﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }  // Foreign key
        public string CompanyName { get; set; }

        public User Users { get; set; }
        public ICollection<Rental> Rentals { get; set; }
    }
}