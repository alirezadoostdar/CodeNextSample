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

        public event Action<string> onChangedPrice;
        public Stock()
        {

        }
        public decimal Price { get; set; }
        public void UpdatePrice(decimal price)
        {
            Price = price;
            onChangedPrice($"Price Update To {price}");
        }
    }
}
