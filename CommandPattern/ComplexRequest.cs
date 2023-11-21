namespace CommandPattern
{
    // However, some commands can delegate more complex operations to other
    // objects, called "receivers."
    class ComplexRequest : IRequest
    {
        private ComplexRequestHandler _complexRequestHandler;

        // Context data, required for launching the receiver's methods.
        private string _a;

        private string _b;

        // Complex commands can accept one or several receiver objects along
        // with any context data via the constructor.
        public ComplexRequest(ComplexRequestHandler complexRequestHandler, string a, string b)
        {
            this._complexRequestHandler = complexRequestHandler;
            this._a = a;
            this._b = b;
        }

        // Commands can delegate to any methods of a receiver.
        public void Handle()
        {
            Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
            this._complexRequestHandler.Handle(this._a);
        }
    }
}