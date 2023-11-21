namespace MediatorPattern;


// Concrete Components implement various functionality. They don't depend on
// other components. They also don't depend on any concrete mediator
// classes.
class SecondHandler : BaseHandler
{
    public void DoC()
    {
        Console.WriteLine("Component 2 does C.");

        this._mediator.Send(this, "C");
    }

    public void DoD()
    {
        Console.WriteLine("Component 2 does D.");

        this._mediator.Send(this, "D");
    }
}