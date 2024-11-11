using Core.Entities.Concrete;
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

        // Product
        public static string ProductAdded = "Product successfully added!";
        public static string ProductNameInvalid = "Product name must be at least two characters!";
        public static string ProductListed = "Products are listed!";
        public static string ProductCountOfCategoryError = "There can be max 15 products on the same category!";
        public static string ProductNameAlreadyExists = "Product name already exists!";

        public static string MaintenanceTime = "The system is under maintenance, try again later!";

        // Category
        public static string CategoryLimitExceeded = "Can not adding a new category because, category Limit is exceeded!";

        // Auth
        public static string AuthorizationDenied = "No Access!";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password error";
        public static string SuccessfulLogin = "Login to the system was successful";
        public static string UserAlreadyExists = "This user already exists";
        public static string UserRegistered = "User successfully registered";
        public static string AccessTokenCreated = "Access token created successfully";
    }
}
