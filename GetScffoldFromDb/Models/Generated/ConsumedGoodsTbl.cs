using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class ConsumedGoodsTbl
{
    public int SysCode { get; set; }

    public int? GoodSysCode { get; set; }

    public int? FkConsumedGoods { get; set; }

    public double? Qty { get; set; }

    public virtual StockTbl? FkConsumedGoodsNavigation { get; set; }
}
