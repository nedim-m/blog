using blog.Models.SearchObjects;
using blog.Services.Database;
using blog.Services.IServices;
using blog.Services.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddTransient<IPostService, PostService>();
builder.Services.AddTransient<IService<blog.Models.Tag,BaseSearchObject>,Service<blog.Models.Tag, Tag, BaseSearchObject>>();








builder.Services.AddAutoMapper(typeof(IPostService));


builder.Services.AddDbContext<blogContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


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
