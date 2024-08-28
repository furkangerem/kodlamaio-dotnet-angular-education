// type safety - tip güvenliği
string categoryLabel = "Category Label";
int totalStudent = 16;
double interestRate = 1.69;
bool isUserLoggedIn = false;
double dollarYesterday = 7.45;
double dollarToday = 7.45;

Console.WriteLine(categoryLabel);

if (isUserLoggedIn)
    Console.WriteLine("User Settings Button");
else
    Console.WriteLine("Login Button");

if (dollarYesterday > dollarToday)
    Console.WriteLine("Decrease.svg");
else if (dollarYesterday < dollarToday)
    Console.WriteLine("Increase.svg");
else
    Console.WriteLine("Stable.svg");