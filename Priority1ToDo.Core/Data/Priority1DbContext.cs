using Microsoft.EntityFrameworkCore;
using Priority1ToDo.Core.Domain;

namespace Priority1ToDo.Core.Data;

public class Priority1DbContext : DbContext
{
    public Priority1DbContext(DbContextOptions<Priority1DbContext> options) : base(options)
    {
    }

    public DbSet<ToDoList> ToDoLists { get; set; }
    public DbSet<ToDo> ToDos { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
    }

}
