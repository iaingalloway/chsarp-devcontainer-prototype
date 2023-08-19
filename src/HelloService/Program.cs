using ClassLibrary;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => MessageService.GetMessage(MessageKind.Hello));

app.Run();
