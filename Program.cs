var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//   GET method for the root URL ("/") that returns a simple "Hello World!" message when accessed. This is a common way to test if the web application is running correctly.

app.MapGet("/games", () => "Hello World!");

app.Run();
