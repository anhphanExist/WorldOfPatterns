
namespace VisitorPattern
{
    // The Component interface declares an `accept` method that should take the
    // base visitor interface as an argument.
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }

    // Each Concrete Component share the same `Accept` method in such a way
    // that it calls the visitor's method corresponding to the component's
    // class by using runtime check (.NET feature of dynamic)
    public abstract class BaseComponent : IComponent
    {
        // Work around double dispatch with dynamic type check
        public virtual void Accept(IVisitor visitor)
        {
            visitor.Visit((dynamic)this);
        }
    }
}