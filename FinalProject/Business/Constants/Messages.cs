using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        // Basic messages. (i18n)
        // Public props are PascalCase.
        public static string ProductAdded = "Product successfully added!";
        public static string ProductNameInvalid = "Product name must be at least two characters!";
        public static string ProductListed = "Products are listed!";

        public static string MaintenanceTime = "The system is under maintenance, try again later!";
    }
}
