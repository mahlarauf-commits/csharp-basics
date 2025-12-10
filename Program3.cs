// See https://aka.ms/new-console-template for more information
try
{
    Console.WriteLine("Enter a number of week:");
    byte dayofweek = byte.Parse(Console.ReadLine());
    if (dayofweek == 1)
    {
        Console.WriteLine("Saturday");
    }
    else if (dayofweek == 2)
    {
        Console.WriteLine("Sunday");
    }
    else if (dayofweek == 3)
    {
        Console.WriteLine("Monday");
    }
    else if (dayofweek == 4)
    {
        Console.WriteLine("Tuesday");
    }
    else if (dayofweek == 5)
    {
        Console.WriteLine("Wednesday");
    }
    else if (dayofweek == 6)
    {
        Console.WriteLine("Thursday");
    }
    else if (dayofweek == 7)
    {
        Console.WriteLine("Friday");
    }
    else
    {
        Console.WriteLine("please enter a number in the range 1 to 7");
    }
}
catch(Exception ex)
{
    Console.WriteLine("please enter a number in the range 1 to 7");
}
