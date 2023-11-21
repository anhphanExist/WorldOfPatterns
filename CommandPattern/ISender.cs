namespace CommandPattern
{
    public interface ISender
    {
        public void Send(IRequest request);
    }

    // The Invoker is associated with one or several commands. It sends a
    // request to the command.
    public class Sender : ISender
    {
        public void Send(IRequest request)
        {
            request.Handle();
        }
    }
}