namespace MediatorPattern
{
    // The Base Component provides the basic functionality of storing a
    // mediator's instance inside component objects.
    class BaseHandler
    {
        protected IMediator _mediator;

        public BaseHandler(IMediator mediator = null)
        {
            this._mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this._mediator = mediator;
        }
    }
}