
namespace VisitorPattern
{
    // The Visitor Interface declares a set of visiting methods that correspond
    // to component classes. The signature of a visiting method allows the
    // visitor to identify the exact class of the component that it's dealing
    // with.
    public interface IVisitor
    {
        void Visit(ConcreteComponentA element) {}

        void Visit(ConcreteComponentB element) {}
    }
}