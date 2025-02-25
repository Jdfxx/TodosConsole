
Console.WriteLine("Hello");


Console.WriteLine("Please input first number: ");
var number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input second number: ");
var number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What would you like to do?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[D]ivide");
Console.WriteLine("[M]multiply");

var input = Console.ReadLine()?.ToUpper();

switch (input)
{
    case "A": Console.WriteLine(number1 + number2);
        break;
    case "S": Console.WriteLine(number1 - number2);
        break;
    case "D": Console.WriteLine(number1 / number2);
        break;
    case "M": Console.WriteLine(number1 * number2);
        break;
    default: Console.WriteLine("Wrong input"); break;
}