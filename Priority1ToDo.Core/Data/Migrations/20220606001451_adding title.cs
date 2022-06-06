using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Priority1ToDo.Core.Migrations
{
    public partial class addingtitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "ToDos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.Sql(@"
                INSERT INTO ToDos (Title, ToDoListId) SELECT 'Build ToDo List App', tdl.Id FROM ToDoLists tdl WHERE tdl.Name = 'Work';
                INSERT INTO ToDos (Title, ToDoListId) SELECT 'Complete a Rubiks Cube', tdl.Id FROM ToDoLists tdl WHERE tdl.Name = 'Goals';
                INSERT INTO ToDos (Title, ToDoListId) SELECT 'Eggs', tdl.Id FROM ToDoLists tdl WHERE tdl.Name = 'Groceries';
                INSERT INTO ToDos (Title, ToDoListId) SELECT 'Milk', tdl.Id FROM ToDoLists tdl WHERE tdl.Name = 'Groceries';
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "ToDos");
        }
    }
}
