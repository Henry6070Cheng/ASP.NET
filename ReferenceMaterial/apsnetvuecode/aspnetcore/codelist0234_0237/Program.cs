var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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

app.MapGet("/hello", async context =>
{
    await context.Response.WriteAsync("Hello, World!");
});

//app.MapGet("/users/{id}", async context =>
//{
//    var id = context.Request.RouteValues["id"];
//    await context.Response.WriteAsync($"User ID: {id}");
//});

app.MapGet("/users/{id:int}", async context =>
{
    var id = context.Request.RouteValues["id"];
    await context.Response.WriteAsync($"User ID: {id}");
});


app.MapControllers();

app.Run();
