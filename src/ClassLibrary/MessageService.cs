namespace ClassLibrary;

public class MessageService
{
  public string GetMessage(MessageKind kind, bool createException)
  {
    if(createException)
    {
      throw new InvalidOperationException();
    }

    return GetMessage(kind);
  }

  public string GetMessage(MessageKind kind) => kind switch
  {
    MessageKind.Hello => "Hello",
    MessageKind.World => "world!",
    _ => throw new InvalidOperationException()
  };
}
