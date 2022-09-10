using BlazorTr.Web.Domain;

namespace BlazorTr.Web.States.Todos;

public class TodoState
{
    private readonly List<Todo> _todos;
    public IReadOnlyCollection<Todo> Todos => _todos;

    public TodoState()
    {
        _todos = new List<Todo>();
    }
    public void Add(TodoDto todo)
    {
        _todos.Add(todo);
    }
}