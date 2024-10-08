using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        // Validation Rules are written in constructors.
        public ProductValidator()
        {
            // According to SOLID rules, one row is created for each rule.
            RuleFor(product => product.ProductName).NotEmpty();
            RuleFor(product => product.ProductName).MinimumLength(2);
            RuleFor(product => product.UnitPrice).NotEmpty();
            RuleFor(product => product.UnitPrice).GreaterThan(0);
            RuleFor(product => product.UnitPrice).GreaterThanOrEqualTo(10).When(product => product.CategoryId == 1);
            // We can create our custom rules.
            RuleFor(product => product.ProductName).Must(StartsWithA).WithMessage("Products must start with A!");
        }

        private bool StartsWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
