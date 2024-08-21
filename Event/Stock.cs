using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class Stock
    {
        //public delegate void OnChangedPrice(string message);
        //public event OnChangedPrice onChangedPrice;

        //public event Action<string> onChangedPrice;

        public event EventHandler<MessageEventArg> ChangedPrice;//استاندارد تعریف ایونت باید مشابه این باشد

        protected virtual void OnChangedPrice(MessageEventArg e)
        {
            ChangedPrice?.Invoke(this, e);
        }
        public Stock()
        {

        }
        public decimal Price { get; set; }
        public void UpdatePrice(decimal price)
        {
            Price = price;
            OnChangedPrice( new MessageEventArg($"Price Update To {price}"));
        }
    }

    public class MessageEventArg(string message) : EventArgs
    {
        public string Message =message;
    }
}
