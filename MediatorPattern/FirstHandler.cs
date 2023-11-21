namespace MediatorPattern;



// Concrete Components implement various functionality. They don't depend on
// other components. They also don't depend on any concrete mediator
// classes.
class FirstHandler : BaseHandler
{
    public void DoA()
    {
        Console.WriteLine("Component 1 does A.");

        this._mediator.Send(this, "A");
    }

    public void DoB()
    {
        Console.WriteLine("Component 1 does B.");

        this._mediator.Send(this, "B");
    }
}