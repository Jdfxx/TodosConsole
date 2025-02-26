// var numbers = new int[3];
//
// numbers[0] = 1;
// numbers[1] = 2;
// numbers[2] = 3;
//
// foreach (var number in numbers)
// {
//     Console.WriteLine(number);
// }

List<string> names = ["Filip", "Monika", "laura", "FILIP12", "FILIP123!", "FILI"];

var lengths = names.Select(name => name.Length).ToList();

lengths.ForEach(Console.WriteLine);

names.Where(name => name.All(char.IsUpper))
    .Where(name => name.All(char.IsLetter))
    .Distinct().ToList().ForEach(Console.WriteLine);