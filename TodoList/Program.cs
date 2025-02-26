using System.Collections;

namespace TodoList;

public class Program
{

    public static void Main(string[] args)
    {
        Todos.Run();
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