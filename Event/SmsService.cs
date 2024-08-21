using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class SmsService
    {
        public void Send(object sender, MessageEventArg e)
        {
            Console.WriteLine($"sms send this message : {e.Message}");
        }
    }
}
