namespace StatePattern
{
    // The Context defines the interface of interest to clients. It also
    // maintains a reference to an instance of a State subclass, which
    // represents the current state of the Context.
    public class Task
    {
        // A reference to the current state of the Context.
        private TaskStateBase _taskState = null;
        private Guid? _assigneeId = null;

        public Task()
        {
            this.TransitionTo(new TaskNew());
        }
        
        public Guid? AssigneeId
        {
            get => _assigneeId;
            set => _assigneeId = value;
        }

        // The Context allows changing the State object at runtime.
        public void TransitionTo(TaskStateBase taskState)
        {
            Console.WriteLine($"Context: Transition to {taskState.GetType().Name}.");
            this._taskState = taskState;
            this._taskState.SetContext(this);
        }

        // The Context delegates part of its behavior to the current State
        // object.
        public void Reset()
        {
            _taskState.Reset();
        }

        public void Assign(Guid assigneeId)
        {
            _taskState.Assign(assigneeId);
        }

        public void UnAssign()
        {
            _taskState.UnAssign();
        }

        public void Bypass()
        {
            _taskState.Bypass();
        }

        public void Reject()
        {
            _taskState.Reject();
        }
    }
}