using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class GoodsQuotaTbl
{
    public int SysCode { get; set; }

    public int FkGoodSysCode { get; set; }

    public int? FkWareHouseId { get; set; }

    public int FkAccountSysCode { get; set; }

    public double Quantity { get; set; }

    public string? SartDateShamsi { get; set; }

    public string? EndDateShamsi { get; set; }

    public DateTime? StartDateMiladi { get; set; }

    public DateTime? EndDateMiladi { get; set; }

    public virtual CodeMngdwntbl FkAccountSysCodeNavigation { get; set; } = null!;

    public virtual StockTbl FkGoodSysCodeNavigation { get; set; } = null!;

    public virtual WareHouseTbl? FkWareHouse { get; set; }
}
