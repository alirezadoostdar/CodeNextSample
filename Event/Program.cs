using Event;

Stock stock = new Stock();
SmsService smsService = new SmsService();
EmailService emailService = new EmailService();

stock.ChangedPrice += smsService.Send;
stock.ChangedPrice += emailService.Send;

while (true)
{
    var price = Random.Shared.Next(100000, 200000);
    stock.UpdatePrice(price);
    Thread.Sleep(1000);
}