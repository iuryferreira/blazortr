using BlazorTr.Web.States.Todos;

namespace BlazorTr.Web.States;

public static class StateConfig
{
    public static void RegisterStates(this IServiceCollection services)
    {
        services.AddSingleton<TodoState>();
    }
}