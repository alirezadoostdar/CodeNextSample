using Microsoft.Extensions.Options;

namespace Options_Pattern
{
    public class SmsService
    {
        public readonly AppSetting _appSetting;

        //IOptions is singleton service
        public SmsService(IOptions<AppSetting> options)
        {
              _appSetting = options.Value;
        }

        //IOptionsSnapshot is a scoped service 
        //public SmsService(IOptionsSnapshot<AppSetting> options)
        //{
        //    _appSetting = options.Value;
        //}

        //IOptionsMonitor is a transient service
        //public SmsService(IOptionsMonitor<AppSetting> options)
        //{
        //    _appSetting = options.CurrentValue;
        //}

        public string Send(string message)
        {
            return _appSetting.Token.ToString();
        }
    }
}
