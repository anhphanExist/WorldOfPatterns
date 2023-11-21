namespace MediatorPattern
{
    // Concrete Mediators implement cooperative behavior by coordinating several
    // components.
    class Mediator : IMediator
    {
        private FirstHandler _firstHandler;

        private SecondHandler _secondHandler;

        public Mediator(FirstHandler firstHandler, SecondHandler secondHandler)
        {
            this._firstHandler = firstHandler;
            this._firstHandler.SetMediator(this);
            this._secondHandler = secondHandler;
            this._secondHandler.SetMediator(this);
        } 

        public void Send(object sender, string command)
        {
            if (command == "A")
            {
                Console.WriteLine("Mediator reacts on A and triggers folowing operations:");
                this._secondHandler.DoC();
            }
            if (command == "D")
            {
                Console.WriteLine("Mediator reacts on D and triggers following operations:");
                this._firstHandler.DoB();
                this._secondHandler.DoC();
            }
        }
    }
}