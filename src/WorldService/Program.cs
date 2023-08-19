using ClassLibrary;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => MessageService.GetMessage(MessageKind.World, false));

app.Run();
