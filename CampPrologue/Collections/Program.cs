string[] names = new string[] { "Furkan", "Kerem", "Emirhan", "Murat" };
Console.WriteLine(names[0]);
Console.WriteLine(names[1]);
Console.WriteLine(names[2]);
Console.WriteLine(names[3]);

names = new string[5];
names[4] = "Faruk";
Console.WriteLine(names[4]);
Console.WriteLine(names[0]); // We have changed the reference, that's why this is empty.

List<string> nameList = new List<string> { "Furkan", "Kerem", "Emirhan", "Murat" };
Console.WriteLine(nameList[0]);
Console.WriteLine(nameList[1]);
Console.WriteLine(nameList[2]);
Console.WriteLine(nameList[3]);
nameList.Add("Faruk");
Console.WriteLine(nameList[4]);
Console.WriteLine(nameList[0]);