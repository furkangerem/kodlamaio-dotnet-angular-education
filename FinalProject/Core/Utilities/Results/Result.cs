using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success, string message) : this(success)
        {
            this.Message = message;
        }

        // Method Overloading
        public Result(bool success)
        {
            this.IsSuccess = success;
        }

        public bool IsSuccess { get; }

        public string Message { get; }
    }
}
