// See https://aka.ms/new-console-template for more information
Console.WriteLine("Multiplication table one to five");
for (int i = 1; i <= 5; i++) 
{
    for (int j = 1; j <= 5; j++) 
    {
        int result = i * j;
        Console.Write(result + "\t"); 
    }
    Console.WriteLine();
    }
Console.WriteLine("The multiplication table is complete!");
Console.ReadKey();
