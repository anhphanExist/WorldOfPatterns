// See https://aka.ms/new-console-template for more information

using MediatorPattern;

internal class Program
{
    public static void Main(string[] args)
    {
        // The client code.
        FirstHandler firstHandler = new FirstHandler();
        SecondHandler secondHandler = new SecondHandler();
        var mediator = new Mediator(firstHandler, secondHandler);

        Console.WriteLine("Client triggers operation A.");
        firstHandler.DoA();

        Console.WriteLine();

        Console.WriteLine("Client triggers operation D.");
        secondHandler.DoD();
    }
}