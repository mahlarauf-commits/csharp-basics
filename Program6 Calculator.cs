// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;

int num1=0;
int num2=0;
Console.WriteLine("welcom to the calculator app1");
Console.WriteLine("please enter a number");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("please enter another number");
num2=int.Parse(Console.ReadLine());

Console.WriteLine("select the operation");
Console.WriteLine("a - add");
Console.WriteLine("s - subtract");
Console.WriteLine("m - multiply");
Console.WriteLine("d - divide");
Console.WriteLine("your operation?");

string operation = Console.ReadLine();
switch (operation)
{
	case "a":
		Console.WriteLine($"Result: { num1} + { num2} = " + (num1 + num2));
		break;
		case "s":
        Console.WriteLine($"Result: {num1} - {num2} = " + (num1 - num2));
        break;
	case "m":
        Console.WriteLine($"Result: {num1} * {num2} = " + (num1 * num2));
		break;
		case "d":
        Console.WriteLine($"Result: {num1} / {num2} = " + (num1 / num2));
		break;
    default:
		break;
}
