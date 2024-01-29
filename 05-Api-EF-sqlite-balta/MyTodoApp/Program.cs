using MyTodoApp.Routes;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//additions:

app.MapGet("/", () => "Hello World!");

app.MapTodoRoutes();

app.Run();
