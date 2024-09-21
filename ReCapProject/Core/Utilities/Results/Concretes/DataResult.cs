using Core.Utilities.Results.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concretes
{
    public class DataResult<T> : Result, IDataResult<T>
    {

        public DataResult(T data, bool status, string message) : base(status, message)
        {
            Data = data;
        }

        public DataResult(T data, bool status) : base(status)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
