// Primitive Types
int num = 10;
int num1 = 30;
num = num1;
num1 = 65;
//num = ? -30-
Console.WriteLine(num);

// Reference Types
int[] numbers = new int[] {10,20,30};
int[] numbers1 = new int[] { 100, 200, 300 };
numbers = numbers1;
numbers1[0] = 999;
// numbers[0] = ? -999-
Console.WriteLine(numbers[0]);