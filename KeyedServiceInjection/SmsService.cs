namespace KeyedServiceInjection
{
    public class SmsService : INotifyService
    {
        private readonly INotifyService _notifyService;
        public SmsService(INotifyService notifyService)
        {
            _notifyService = notifyService;
        }
        public void Push(string message)
        {
            throw new NotImplementedException();
        }
    }
}
