Console.WriteLine("Hello, World!");  while (true)
{
    Console.Write("How old are you?: ");
    var enteredAge = Console.ReadLine();     
if (int.TryParse(enteredAge, out int age))
    {
        Console.WriteLine($"You are {age} years old!");
        break;
    }
    else
    {
        System.Console.WriteLine("What are you, a moron! Enter a number, fool!");
    }
}