// See https://aka.ms/new-console-template for more information

namespace StatePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The client code.
            var task = new Task();
            task.Reset();
            task.Assign(Guid.NewGuid());
        }
    }
}