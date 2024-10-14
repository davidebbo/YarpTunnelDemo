var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    Console.WriteLine($"Hello World 2! {DateTime.Now}");
    return "Hello World 2!";
});

app.Run();
