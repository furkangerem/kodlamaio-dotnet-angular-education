using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        // Validation Rules are written in constructors.
        public CarImageValidator()
        {
            // According to SOLID rules, one row is created for each rule.
            RuleFor(carImage => carImage.CarId).NotEmpty();
            RuleFor(carImage => carImage.ImagePath).NotEmpty();
        }
    }
}
