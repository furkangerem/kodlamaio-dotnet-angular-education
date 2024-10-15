using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        // According to SOLID rules, one row is created for each rule.
        public UserValidator()
        {
            RuleFor(rental => rental.FirstName).NotEmpty();
            RuleFor(rental => rental.LastName).NotEmpty();
            RuleFor(rental => rental.Email).NotEmpty();
            RuleFor(rental => rental.Password).NotEmpty();
        }
    }
}
