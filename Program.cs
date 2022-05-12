var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello DevOps World!");
app.MapGet("/abc", () => "Hello ABC!");

app.Run();
