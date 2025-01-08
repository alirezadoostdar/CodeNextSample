using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_challange
{
    public class CommitionCalculator
    {
        public static decimal CalculateTradeCommision(SecuritiesTrade trade) => trade switch
        {
            StockTrade { quantity: var q} when q==0 => throw new ArgumentException("Invalid trade") ,
            StockTrade { quantity: var q,price: var p} when q>=100 && (q*p) >= 10000.0m => 10.0m,
            BondTrade { quantity: var q,price: var p} when q>=100 && (q*p) >= 20000.0m => 20.0m,
            _ => 0.0m
        };


        public static void PrintTradeCommision(SecuritiesTrade trade)
        {
            decimal commision = 0.0m;
            commision = CalculateTradeCommision(trade);
            if (trade is StockTrade)
            {
                Console.WriteLine($"Stock trade is {commision}");
            }
            else if(trade is BondTrade) 
            {
                Console.WriteLine($"Bond trade is {commision}");

            }
        }
    }
}
