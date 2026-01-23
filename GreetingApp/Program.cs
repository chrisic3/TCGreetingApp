Console.WriteLine("Welcome to The Greeting Application!");
Console.WriteLine("We are glad you are here.");
Console.WriteLine("------------------------------------");
Console.WriteLine();

Console.Write("What is your name: ");
string? userName = Console.ReadLine();
Console.WriteLine();

Console.WriteLine($"Hello! It's a pleasure to meet you, { userName }.");
Console.WriteLine();

Console.WriteLine("Thank you for using The Greeting Application. Goodbye.");
Console.ReadLine();