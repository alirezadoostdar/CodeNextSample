using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class EmailService
    {
        public void Send(string message)
        {
            Console.WriteLine($"email send this message : {message}");
        }
    }
}
