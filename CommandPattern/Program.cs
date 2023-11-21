namespace CommandPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            // The client code can parameterize an invoker with any commands.
            ISender sender = new Sender();
            sender.Send(new SimpleRequest("Say Hi!"));
            var complexRequestHandler = new ComplexRequestHandler();
            sender.Send(new ComplexRequest(complexRequestHandler, "Send email", "Save report"));
        }
    }
}