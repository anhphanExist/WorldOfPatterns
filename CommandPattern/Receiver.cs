namespace CommandPattern
{
    
    // The Receiver classes contain some important business logic. They know how
    // to perform all kinds of operations, associated with carrying out a
    // request. In fact, any class may serve as a Receiver.
    class ComplexRequestHandler : IComplexRequestHandler
    {
        public void Handle(string a)
        {
            Console.WriteLine($"Receiver: Working on ({a}.)");
        }
    }
}