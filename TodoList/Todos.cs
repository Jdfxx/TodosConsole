using System.Collections;

namespace TodoList;

public class Todos
{
    public void Run()
    {
        Console.WriteLine("Hello!");

        var todos = new ArrayList();

        while (true)
        {
            ShowMenu();
            var input = Console.ReadKey().KeyChar.ToString().ToUpper();

            switch (input)
            {
                case "E": Exit(); break;
                case "V": ShowAll(todos); break;
                case "A": AddTodo(todos); break;
                default: ShowMenu(); break;
            }
        }
    }

    public void AddTodo(ArrayList todos)
    {
        Console.Clear();
        Console.WriteLine("Please type in a new TODO: \n");

        var todo = Console.ReadLine();

        todos.Add(todo);
        PressToContinue();
    }

    public void ShowAll(ArrayList todos)
    {
        Console.Clear();
        var counter = 1;
        if (todos.Count == 0)
            Console.WriteLine("No todos found!");
        else
            foreach (var todo in todos)
                Console.WriteLine(counter++ + ". " + todo);

        PressToContinue();
    }

    public void PressToContinue()
    {
        Console.WriteLine("\n Press any key to continue!");
        Console.ReadKey();
    }

    public void Exit()
    {
        Console.Clear();
        Console.WriteLine("Byeeee");
        Environment.Exit(0);
    }

    public void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("What would you like to do!");
        Console.WriteLine("\n[A]dd TODO");
        Console.WriteLine("[D]elete TODO");
        Console.WriteLine("[V]iew all TODOS");
        Console.WriteLine("[E]xit\n");
    }
}