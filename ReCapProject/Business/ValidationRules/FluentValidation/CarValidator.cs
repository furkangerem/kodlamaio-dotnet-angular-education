using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        // Validation Rules are written in constructors.
        public CarValidator()
        {
            // According to SOLID rules, one row is created for each rule.
            RuleFor(car => car.Name).NotEmpty();
            RuleFor(car => car.Name).MinimumLength(4);
            RuleFor(car => car.BrandId).NotEmpty();
            RuleFor(car => car.ColorId).NotEmpty();
            RuleFor(car => car.ModelYear).NotEmpty();
            RuleFor(car => car.DailyPrice).GreaterThan(0);
            RuleFor(car => car.Description).NotEmpty();
        }
    }
}
