using Code9.Domain.Commands;
using Code9.Domain.Interfaces;
using Code9.Infrastructure;
using Code9.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CinemaDbContext>(options =>
    options.UseInMemoryDatabase("Cinema"));
builder.Services.AddScoped<ICinemaRepository, CinemaRepository>();

builder.Services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(AddCinemaCommand).Assembly));

builder.Services.AddControllers();

// Add logging service as a singleton
builder.Services.AddSingleton<ILogger>(sp =>
{
    var loggerFactory = sp.GetRequiredService<ILoggerFactory>();
    return loggerFactory.CreateLogger("MyLogger");
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    using var scope = app.Services.CreateScope();
    using var dbContext = scope.ServiceProvider.GetRequiredService<CinemaDbContext>();
    dbContext.Database.EnsureCreated();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
