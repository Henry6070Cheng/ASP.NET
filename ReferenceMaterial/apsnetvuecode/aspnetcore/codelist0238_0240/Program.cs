using codelist0238_0240;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.HttpsPolicy;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<CustomExceptionFilter>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

//app.UseExceptionHandler("/error");

//app.MapGet("/error", async context =>
//{
//    var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
//    var exception = exceptionHandlerPathFeature?.Error;
//    await context.Response.WriteAsync($"error: {exception?.Message}");
//});

app.MapControllers();

app.Run();
