using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        // Basic messages. (i18n)
        // Public props are PascalCase.
        public static string CarAdded = "Car is added successfully!";
        public static string CarDeleted = "Car is deleted successfully!";
        public static string CarUpdated = "Car is updated successfully!";
        public static string CarListed = "Cars are listed!";
        public static string CarFound = "Car is found successfully!";

        public static string BrandAdded = "Brand is added successfully!";
        public static string BrandDeleted = "Brand is deleted successfully!";
        public static string BrandUpdated = "Brand is updated successfully!";
        public static string BrandListed = "Brand are listed!";
        public static string BrandFound = "Brand is found successfully!";

        public static string ColorAdded = "Color is added successfully!";
        public static string ColorDeleted = "Color is deleted successfully!";
        public static string ColorUpdated = "Color is updated successfully!";
        public static string ColorListed = "Color are listed!";
        public static string ColorFound = "Color is found successfully!";

        public static string CarDailyRateMissing = "The daily rate for the car can't be 0!";
        public static string CarNameMissing = "The length of the car name entered for the vehicle must be at least 2 characters!";
        public static string CarNotExist = "You can not do anything on nonexisting car!";

        public static string BrandNameMissing = "The length of the brand name must be at least 3 characters!";
        public static string BrandNotExist = "You can not do anything on nonexisting brand!";

        public static string ColorNameMissing = "The length of the color name must be at least 3 characters!";
        public static string ColorNotExist = "You can not do anything on nonexisting color!";

        public static string MaintenanceTime = "The system is under maintenance, try again later!";
    }
}
