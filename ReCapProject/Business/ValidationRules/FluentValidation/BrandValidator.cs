using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        // Validation Rules are written in constructors.
        public BrandValidator()
        {
            // According to SOLID rules, one row is created for each rule.
            RuleFor(brand => brand.Name).NotEmpty();
        }
    }
}
