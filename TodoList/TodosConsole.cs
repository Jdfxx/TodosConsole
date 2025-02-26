﻿namespace TodoList;

public class TodosConsole : Todos
{
    public override void Run()
    {
        Console.WriteLine("Hello!");

        List<string> todos = [];

        while (true)
        {
            ShowMenu();
            var input = Console.ReadKey().KeyChar.ToString().ToUpper();

            switch (input)
            {
                case "E": Exit(); break;
                case "V": ShowAll(todos);  break;
                case "A": AddTodo(todos); break;
                case "D": Delete(todos); break;
                default: ShowMenu(); break;
            }
        }
    }

    protected override void Delete(List<string> todos)
    {
        Console.Clear();

        todos.ForEach(todo =>
        {
            var indexOf = todos.IndexOf(todo);
            Console.WriteLine($"{indexOf+1}. {todo}");
        });
        Console.WriteLine("Which TODO would you like to delete: ");
        Console.WriteLine("Please enter a number: ");
        var input = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        
        todos.RemoveAt(input-1);

        Console.WriteLine("Deleting todo..");
        Console.WriteLine("Done!");
        PressToContinue();
    }

    protected override void AddTodo(List<string> todos)
    {
        Console.Clear();
        Console.WriteLine("Please type in a new TODO: \n");

        var todo = Console.ReadLine();

        if (todo != null) todos.Add(todo);
        Console.WriteLine("Todo added");
        PressToContinue();
    }

    protected override void ShowAll(List<string> todos)
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

    protected override void PressToContinue()
    {
        Console.WriteLine("\n Press any key to continue!");
        Console.ReadKey();
    }

    protected override void Exit()
    {
        Console.Clear();
        Console.WriteLine("Byeeee");
        Environment.Exit(0);
    }

    protected override void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("What would you like to do!");
        Console.WriteLine("\n[A]dd TODO");
        Console.WriteLine("[D]elete TODO");
        Console.WriteLine("[V]iew all TODOS");
        Console.WriteLine("[E]xit\n");
    }
}