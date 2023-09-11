string response = Console.ReadLine().Trim();

while (string.IsNullOrEmpty(response))
{
    Console.WriteLine("You didn't choose anything, try again!");
    response = Console.ReadLine().Trim();
}

Console.WriteLine($"You chose: {response}");