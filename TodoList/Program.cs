using System.Collections;

namespace TodoList;

public class Program
{
    public Todos Todos = new Todos();

    public static void Main(string[] args)
    {
        var program = new Program();
        program.Todos.Run();
    }
}