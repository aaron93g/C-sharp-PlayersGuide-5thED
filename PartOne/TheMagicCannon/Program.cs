// See https://aka.ms/new-console-template for more information
for(int i = 1; i <= 50; i++)
{
    if(!(i % 3 == 0) && !(i % 5 == 0))
    {
        Console.ResetColor();
        Console.WriteLine($"{i}: Normal");
    }
    else if((i % 5 == 0) && (i % 3 == 0))
    {
        Console.Write(i + ": ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Fire & Electric Combo");
        Console.ResetColor();
    }
    else if(i % 3 == 0)
    {
        Console.Write(i + ": ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Fire");
        Console.ResetColor();
    }
    else if(i % 5 == 0)
    {
        Console.Write(i + ": ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Electric");
        Console.ResetColor();
    }
}
