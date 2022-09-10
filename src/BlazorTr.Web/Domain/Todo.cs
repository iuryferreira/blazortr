namespace BlazorTr.Web.Domain;

public class Todo
{
    private static int _idCounter;
    
    public Todo(string text)
    {
        _idCounter++;
        Id = _idCounter;
        Text = text;
    }

    public int Id { get; }
    public string Text { get; }
    public bool Done { get; private set; }

    public void Toggle()
    {
        Done = !Done;
    }

    public static implicit operator Todo(TodoDto data)
    {
        return new Todo(data.Text);
    }
}

public record TodoDto(string Text);