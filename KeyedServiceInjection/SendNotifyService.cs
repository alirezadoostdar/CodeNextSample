namespace KeyedServiceInjection
{
    public class SendNotifyService
    {
        private readonly INotifyService _notifyService;
        public SendNotifyService([FromKeyedServices(nameof(EmailService))] INotifyService notifyService)
        {
            _notifyService = notifyService;
        }
        //public SendNotifyService([FromKeyedServices(nameof(SmsService))] INotifyService notifyService)
        //{
        //    _notifyService = notifyService;
        //}

        public void Send(string message)
        {
            _notifyService.Push(message);
        }
    }
}
