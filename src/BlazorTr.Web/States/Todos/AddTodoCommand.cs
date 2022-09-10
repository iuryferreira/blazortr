using BlazorTr.Web.Domain;
using MediatR;

namespace BlazorTr.Web.States.Todos;

public class AddTodoCommand : IRequest
{
    public string Text { get; init; }
}

public class AddTodoHandler : IRequestHandler<AddTodoCommand>
{
    private readonly TodoState _state;

    public AddTodoHandler(TodoState state)
    {
        _state = state;
    }

    public Task<Unit> Handle(AddTodoCommand request, CancellationToken cancellationToken)
    {
        _state.Add(new TodoDto(request.Text));
        return Unit.Task;
    }
}