using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class EmailService
    {
        public void Send(object sender, MessageEventArg e)
        {
            Console.WriteLine($"email send this message : {e.Message}");
        }
    }
}
