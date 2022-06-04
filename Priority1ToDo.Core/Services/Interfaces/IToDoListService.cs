using Priority1ToDo.Core.Domain;

namespace Priority1ToDo.Core.Services.Interfaces;

public interface IToDoListService
{
    Task<ToDoList> GetAsync(int id);
    Task<List<ToDoList>> GetAllAsync();
    Task<ToDoList> CreateAsync(ToDoList toDoList);
    Task DeleteAsync(int id);
}