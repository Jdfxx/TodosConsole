namespace TodoList;

public abstract class Todos
{
    public abstract void Run();
    protected abstract void Delete(List<string> todos);
    protected abstract void AddTodo(List<string> todos);
    protected abstract void ShowAll(List<string> todos);
    protected abstract void PressToContinue();
    protected abstract void Exit();
    protected abstract void ShowMenu();
}