using BD.DataAccess;
using BD.Mapping;
using BD.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = string.Empty;
connection = builder.Configuration.GetConnectionString("MySQLServer");

builder.Services.AddDbContext<DbContext, FilmDb>(options =>
    options.UseSqlServer(connection));

builder.Services.AddTransient<IFilmRepo, FilmRepo>();
builder.Services.AddTransient<IFilmService, FilmService>();
builder.Services.AddTransient<ICompanyRepo, CompanyRepo>();
builder.Services.AddTransient<ICompanyService, CompanyService>();
builder.Services.AddTransient<IActorRepo, ActorRepo>();
builder.Services.AddTransient<IActorService, ActorService>();
builder.Services.AddTransient<IActorFilmRepo, ActorFilmRepo>();

builder.Services.AddAutoMapper(typeof(FirstApiMappingProfile));

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