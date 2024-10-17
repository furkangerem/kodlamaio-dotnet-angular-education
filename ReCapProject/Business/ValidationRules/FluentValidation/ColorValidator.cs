using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator : AbstractValidator<Color>
    {
        // Validation Rules are written in constructors.
        public ColorValidator()
        {
            // According to SOLID rules, one row is created for each rule.
            RuleFor(color => color.Name).NotEmpty();
            RuleFor(color => color.Name).MinimumLength(4);
        }
    }
}
