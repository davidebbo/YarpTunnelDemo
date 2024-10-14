var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    Console.WriteLine($"Hello World! {DateTime.Now}");
    return "Hello World!";
});

app.Run();
