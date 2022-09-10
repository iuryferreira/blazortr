using BlazorTr.Web.Domain;
using MediatR;

namespace BlazorTr.Web.States.Todos;

public class ReadTodosCommand : IRequest<IReadOnlyCollection<Todo>> { }

public class ReadTodosHandler : IRequestHandler<ReadTodosCommand, IReadOnlyCollection<Todo>>
{
    private readonly TodoState _state;

    public ReadTodosHandler(TodoState state)
    {
        _state = state;
    }

    public Task<IReadOnlyCollection<Todo>> Handle(ReadTodosCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_state.Todos);
    }
}