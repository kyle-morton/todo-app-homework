using Microsoft.EntityFrameworkCore;
using Priority1ToDo.Core.Data;
using Priority1ToDo.Core.Services;
using Priority1ToDo.Core.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<Priority1DbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<IToDoListService, ToDoListService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
