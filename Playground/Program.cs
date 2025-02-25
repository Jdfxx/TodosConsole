var numbers = new int[3];

numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine(numbers[^1]);
Console.WriteLine(numbers[^2]);
