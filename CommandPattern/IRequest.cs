namespace CommandPattern
{
    // The Command interface declares a method for executing a command.
    public interface IRequest
    {
        void Handle();
    }
}