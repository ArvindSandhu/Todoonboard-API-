using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using todoonboard_api.Models;
using todoonboard_api.Helpers;
using todoonboard_api.Services;



var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration= builder.Configuration;


// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<TodoContext>(opt =>
    opt.UseSqlServer(configuration.GetConnectionString("WebApiDatabase")));
builder.Services.Configure<AppSettings>(configuration.GetSection("AppSettings"));
builder.Services.AddScoped<IUserService, UserService>();
// builder.Services.AddDbContext<TodoContext>(opt =>
//     opt.UseSqlServer(configuration.GetConnectionString("WebApiDatabase")));
//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new() { Title = "TodoApi", Version = "v1" });
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseCors(x => x
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());

    // custom jwt auth middleware
    app.UseMiddleware<JwtMiddleware>();

    app.MapControllers();
    app.UseDeveloperExceptionPage();
    //app.UseSwagger();
    //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TodoApi v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.Run();