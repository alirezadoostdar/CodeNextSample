namespace Options_Pattern;

public class AppSetting
{
    public int SmsProvider { get; set; }
    public Guid Token { get; set; }
    public Scheduler Scheduler { get; set; }
}

public class Scheduler
{
    public bool Enabled { get; set; }
    public TimeOnly AutoRetryDelay { get; set; }
    public string SecretKey { get; set; }
}
