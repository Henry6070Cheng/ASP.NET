using lesson04_1.Services;

namespace lesson04_1;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddGrpc();

        var app = builder.Build();

        app.MapGrpcService<GreeterService>();

        app.Run();
    }
}