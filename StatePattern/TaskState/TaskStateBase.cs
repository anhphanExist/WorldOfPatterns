namespace StatePattern
{
    // The base State class declares methods that all Concrete State should
    // implement and also provides a backreference to the Context object,
    // associated with the State. This backreference can be used by States to
    // transition the Context to another State.
    public abstract class TaskStateBase
    {
        protected Task Task;

        public void SetContext(Task task)
        {
            this.Task = task;
        }

        public virtual void Reset()
        {
            Task.TransitionTo(new TaskNew());
        }

        public virtual void Assign(Guid? assigneeId)
        {
            Task.TransitionTo(new TaskTodo(assigneeId));
        }

        public virtual void UnAssign()
        {
            Task.TransitionTo(new TaskTodo(assigneeId: null));
        }

        public virtual void Bypass()
        {
            Task.TransitionTo(new TaskBypassed());
        }

        public virtual void Reject()
        {
            Task.TransitionTo(new TaskRejected());
        }
    }
}