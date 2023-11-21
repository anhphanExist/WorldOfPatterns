namespace StatePattern;

class TaskTodo : TaskStateBase
{
    public TaskTodo(Guid? assigneeId)
    {
        Task.AssigneeId = assigneeId;
    }

    public override void Reset()
    {
    }

    public override void Assign(Guid? assigneeId)
    {
        this.Task.TransitionTo(new TaskTodo(assigneeId));
    }
}