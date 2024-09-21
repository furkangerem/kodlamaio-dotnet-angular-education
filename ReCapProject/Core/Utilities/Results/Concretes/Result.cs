using Core.Utilities.Results.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concretes
{
    public class Result : IResult
    {

        public Result(bool status, string message) : this(status)
        {
            this.Message = message;
        }

        public Result(bool status)
        {
            this.IsSuccess = status;
        }

        public bool IsSuccess { get; }

        public string Message { get; }
    }
}
