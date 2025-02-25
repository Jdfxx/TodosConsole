using System.Collections;

namespace TodoList;

public class Program
{
    public Todos Todos = new Todos();

    public static void Main(string[] args)
    {
        var program = new Program();
        // program.Todos.Run();
        int result = Add(1, 2);
        Console.WriteLine(result);
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static bool IsLong(string input)
    {
        return input.Length > 10;
    }

    static int Abs(int a, int b)
    {
        return Math.Abs(a - b);
    }
}