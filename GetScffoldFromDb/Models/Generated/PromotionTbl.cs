using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class PromotionTbl
{
    public int Id { get; set; }

    public int? FkMainGoodSysCode { get; set; }

    public int? FkPromotionGoodSysCode { get; set; }

    public double BuyQuantity { get; set; }

    public double PromotionQuantity { get; set; }

    public bool? IsLoop { get; set; }

    public virtual StockTbl? FkMainGoodSysCodeNavigation { get; set; }

    public virtual StockTbl? FkPromotionGoodSysCodeNavigation { get; set; }
}
