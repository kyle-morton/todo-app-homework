namespace Priority1ToDo.Core.Domain;

public class ToDoList : EntityBase
{
    public string Name { get; set; }
    public List<ToDo> ToDos { get; set; }
}
