using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_challange
{
    public class SecuritiesTrade
    {
        public int quantity { get; set; }
        public decimal price { get; set; }
    }

    public class StockTrade : SecuritiesTrade
    {
        public string? symbol { get; set; }
    }

    public class BondTrade : SecuritiesTrade
    {
        public string? name { get; set; }
        public int duration { get; set; }
    }
}
