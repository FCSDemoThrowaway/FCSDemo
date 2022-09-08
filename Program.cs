using FCSDemo.Models;
using FCSDemo.Repositories;
using FCSDemo.Services;
using FCSDemo.Stores;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Dependency injection!
builder.Services.AddSingleton<IStore<Movie>, MovieStore>();
builder.Services.AddSingleton<IRepository<Movie>, MovieRepository>();
builder.Services.AddSingleton<IMovieService, MovieService>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();

string amiga =

@"
                       ONLY
                  _    _ __    __
            /|    /|  /| ||  //' |    /|
           /||   /|| /|| || /|  __   /||
          /-||  / ||/ || || ||  ||  /-||
         /  || /  |/  || || \_\,|/ /  ||
        ""  """"      "" ""   ""  ""  ""
                MAKES IT POSSIBLE!

    https://www.youtube.com/watch?v=PWeO5IkCssk

          Thanks for the coffee, guys ;P
              Great meeting you all!
";