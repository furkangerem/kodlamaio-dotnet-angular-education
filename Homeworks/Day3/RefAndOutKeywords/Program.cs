// An example for Ref Keyword
void Increase(ref int number)
{
    number += 10;
}

int myNumber = 5;
Increase(ref myNumber);
Console.WriteLine(myNumber);  // Return: 15

// An example for Out Keyword
void GetValues(out int number1, out int number2)
{
    number1 = 10;
    number2 = 20;
}

int a, b;
GetValues(out a, out b);
Console.WriteLine(a);  // Return: 10
Console.WriteLine(b);  // Return: 20