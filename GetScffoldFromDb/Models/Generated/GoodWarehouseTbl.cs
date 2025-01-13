using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class GoodWarehouseTbl
{
    public int SysCode { get; set; }

    public int WareHouseSysCode { get; set; }

    public int GoodSysCode { get; set; }

    public int OrderPoint { get; set; }

    public int MaxQty { get; set; }

    public virtual StockTbl GoodSysCodeNavigation { get; set; } = null!;

    public virtual WareHouseTbl WareHouseSysCodeNavigation { get; set; } = null!;
}
