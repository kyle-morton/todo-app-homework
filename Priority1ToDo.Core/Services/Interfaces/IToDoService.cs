using Priority1ToDo.Core.Domain;

namespace Priority1ToDo.Core.Services.Interfaces;

public interface IToDoService
{
    Task<ToDo> CreateAsync(ToDo todo);
    Task SetAsDoneAsync(int toDoId);
    Task DeleteAsync(int toDoId);
}
