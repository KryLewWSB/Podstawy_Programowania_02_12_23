string name = "John";
int age = 30;
//Pierwszy sposób:
string message = $"Hello, my name is {name} and I am {age} years old.";
Console.WriteLine(message);
//Drugi sposób:
string message2 = "Hello, my name is " + name + " and I am " + age + " years old.";
Console.WriteLine(message2);

Console.WriteLine($"Test: {2 + 4}" );