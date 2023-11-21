namespace StatePattern;

class TaskNew : TaskStateBase
{
    public override void Assign(Guid? assigneeId)
    {
        Task.TransitionTo(new TaskTodo(assigneeId));
    }
}