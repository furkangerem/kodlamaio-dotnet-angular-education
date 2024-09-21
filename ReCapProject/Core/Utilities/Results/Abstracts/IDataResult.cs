using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Abstracts
{
    public interface IDataResult<T> : IResult
    {
        // IDataResult = IResult (status, message) + Data<T>
        T Data { get; }
    }
}
