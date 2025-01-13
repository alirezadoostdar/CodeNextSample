using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class GoodVisitorTbl
{
    public int SysCode { get; set; }

    public int AccountSysCode { get; set; }

    public int GoodSysCode { get; set; }

    public float SalePer { get; set; }

    public decimal SaleFee { get; set; }

    public float MarjoPer { get; set; }

    public decimal MarjoFee { get; set; }

    public virtual CodeMngdwntbl AccountSysCodeNavigation { get; set; } = null!;

    public virtual StockTbl GoodSysCodeNavigation { get; set; } = null!;
}
