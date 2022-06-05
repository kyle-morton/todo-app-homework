using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Priority1ToDo.Core.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                insert into ToDoLists (Name) values ('Work');
                insert into ToDoLists (Name) values ('Goals');
                insert into ToDoLists (Name) values ('Groceries');
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
