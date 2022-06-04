using Priority1ToDo.Core.Data;
using Priority1ToDo.Core.Domain;
using Priority1ToDo.Core.Services.Interfaces;

namespace Priority1ToDo.Core.Services;

public class ToDoService : ServiceBase, IToDoService
{
    public ToDoService(Priority1DbContext context) : base(context)
    {
    }

    public Task<ToDo> CreateAsync(ToDo todo)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int toDoId)
    {
        throw new NotImplementedException();
    }

    public Task SetAsDoneAsync(int toDoId)
    {
        throw new NotImplementedException();
    }
}
