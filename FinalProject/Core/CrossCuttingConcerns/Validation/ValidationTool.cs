using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator iValidator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = iValidator.Validate(context);
            if (!result.IsValid)
                throw new FluentValidation.ValidationException(result.Errors);
        }
    }
}
