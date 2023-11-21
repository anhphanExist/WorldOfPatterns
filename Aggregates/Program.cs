internal class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddMediatR(options =>
        {
            options.RegisterServicesFromAssemblyContaining<Program>();
        });

        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");

        app.Run();
    }
}