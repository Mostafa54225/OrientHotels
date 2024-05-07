using OrientHGAPI.Middleware;
using OrientHGAPI.Models;
using Microsoft.EntityFrameworkCore;
using OrientHGAPI.OPModels;
using OrientHGAPI.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<OrientHgwsdbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlServerOptions => sqlServerOptions.EnableRetryOnFailure()));

builder.Services.AddDbContext<OrientHgopedbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("OPDBConnectionString"),
        sqlServerOptions => sqlServerOptions.EnableRetryOnFailure()));

builder.Services.AddScoped<IEmailSender, EmailSender>();

builder.Services.AddCors(options => {
    options.AddPolicy("AllowAnyOrigin", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();
// Configure the HTTP request pipeline.

if (app.Environment.IsProduction() || app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseMiddleware<ExceptionMiddleware>();

app.UseStatusCodePagesWithReExecute("/errors/{0}");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("AllowAnyOrigin");

app.Run();
