namespace ClassLibrary;

public static class MessageService
{
  public static string GetMessage(MessageKind kind, bool createException) => createException ? throw new InvalidOperationException() : GetMessage(kind);

  public static string GetMessage(MessageKind kind) => kind switch
  {
    MessageKind.Hello => "Hello",
    MessageKind.World => "world!",
    _ => throw new InvalidOperationException(),
  };
}
