using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        // Validation Rules are written in constructors.
        public CustomerValidator()
        {
            // According to SOLID rules, one row is created for each rule.
            RuleFor(customer => customer.UserId).NotEmpty();
            RuleFor(customer => customer.CompanyName).NotEmpty();
        }
    }
}
