using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Auxiliaries.GuidAuxiliary
{
    public class GuidCreator
    {
        public static string CreateGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
