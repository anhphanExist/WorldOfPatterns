namespace CommandPattern
{
    // Some commands can implement simple operations on their own.
    class SimpleRequest : IRequest
    {
        private string _payload = string.Empty;

        public SimpleRequest(string payload)
        {
            this._payload = payload;
        }

        public void Handle()
        {
            Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({this._payload})");
        }
    }
}