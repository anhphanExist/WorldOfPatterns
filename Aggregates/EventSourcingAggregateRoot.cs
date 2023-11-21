namespace Aggregates
{
    public abstract class EventSourcingAggregateRoot : IAggregateRoot
    {
        private readonly List<IDomainEvent> _domainEvents;
        private int _version;
        
        protected EventSourcingAggregateRoot()
        {
            _domainEvents = new List<IDomainEvent>();
            _version = -1;
        }
        
        public IReadOnlyCollection<IDomainEvent> GetDomainEvents() => _domainEvents.AsReadOnly();

        public int Version
        {
            get => _version;
            private set => _version = value;
        }

        protected void AddDomainEvent(IDomainEvent @event)
        {
            _domainEvents.Add(@event);
        }

        public void Load(IEnumerable<IDomainEvent> history)
        {
            foreach (var e in history)
            {
                Apply(e);
                Version++;
            }
        }
        protected abstract void Apply(IDomainEvent @event);

    }
}