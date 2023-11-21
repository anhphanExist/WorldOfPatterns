// See https://aka.ms/new-console-template for more information

using VisitorPattern;

internal class Program
{
    public static void Main(string[] args)
    {
        List<IComponent> components = new List<IComponent>
        {
            new ConcreteComponentA(),
            new ConcreteComponentB()
        };

        Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
        var visitor1 = new ConcreteVisitor1();
        Client.ClientCode(components,visitor1);

        Console.WriteLine();

        Console.WriteLine("It allows the same client code to work with different types of visitors:");
        var visitor2 = new ConcreteVisitor2();
        Client.ClientCode(components, visitor2);
    }
}

public class Client
{
    // The client code can run visitor operations over any set of elements
    // without figuring out their concrete classes. The accept operation
    // directs a call to the appropriate operation in the visitor object.
    public static void ClientCode(List<IComponent> components, IVisitor visitor)
    {
        foreach (var component in components)
        {
            component.Accept(visitor);
        }
    }
}