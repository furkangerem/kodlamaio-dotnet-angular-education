using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    // This Interface is created for basic Void Methods.
    public interface IResult
    {
        bool IsSuccess { get; }
        string Message { get; }
    }
}
