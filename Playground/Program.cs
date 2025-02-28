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

using Playground;

List<string> names = ["Filip", "Monika", "laura", "FILIP12", "FILIP123!", "FILI"];

var lengths = names.Select(name => name.Length).ToList();

lengths.ForEach(Console.WriteLine);

names.Where(name => name.All(char.IsUpper))
    .Where(name => name.All(char.IsLetter))
    .Distinct().ToList().ForEach(Console.WriteLine);
    
    var pizzaDay = new DateTime(2023, 2, 9);

    Console.WriteLine($"Year is {pizzaDay.Year}");
    Console.WriteLine($"Month is {pizzaDay.Month}");
    Console.WriteLine($"Day is {pizzaDay.Day}");
    Console.WriteLine($"Day of the week is {pizzaDay.DayOfWeek}");
    
    pizzaDay = pizzaDay.AddYears(1);

    Console.WriteLine($"Year is {pizzaDay.Year}");
    Console.WriteLine($"Month is {pizzaDay.Month}");
    Console.WriteLine($"Day is {pizzaDay.Day}");
    Console.WriteLine($"Day of the week is {pizzaDay.DayOfWeek}");
    
    
    var rectangle = new Rectangle(4,5);

    Console.WriteLine(rectangle);

    var booking = new HotelBooking("Filip" , DateTime.Now, 20);

    Console.WriteLine(booking.GuestName);
    