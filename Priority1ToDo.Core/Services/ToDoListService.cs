using Microsoft.EntityFrameworkCore;
using Priority1ToDo.Core.Data;
using Priority1ToDo.Core.Domain;
using Priority1ToDo.Core.Services.Interfaces;

namespace Priority1ToDo.Core.Services;

public class ToDoListService : ServiceBase, IToDoListService
{
    public ToDoListService(Priority1DbContext context) : base(context)
    {
    }

    public async Task<ToDoList> CreateAsync(ToDoList toDoList)
    {
        await _context.ToDoLists.AddAsync(toDoList);
        await _context.SaveChangesAsync();

        return toDoList;
    }

    public async Task DeleteAsync(int id)
    {
        var toDoList = await _context.ToDoLists.FirstOrDefaultAsync(l => l.Id == id);
        if (toDoList == null)
        {
            return;
        }

        _context.Remove(toDoList);
        await _context.SaveChangesAsync();
    }

    public async Task<List<ToDoList>> GetAllAsync()
    {
        return await _context.ToDoLists
            .Include(t => t.ToDos)
            .ToListAsync();
    }

    public async Task<ToDoList> GetAsync(int id)
    {
        return await _context.ToDoLists
            .Include(t => t.ToDos)
            .FirstOrDefaultAsync(l => l.Id == id);
    }
}
