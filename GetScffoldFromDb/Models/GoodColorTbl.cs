using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class GoodColorTbl
{
    public string ColorName { get; set; } = null!;

    public int GoodSysCode { get; set; }

    public int SysCode { get; set; }

    public virtual StockTbl GoodSysCodeNavigation { get; set; } = null!;

    public virtual ICollection<InventoryDetailTbl> InventoryDetailTbls { get; set; } = new List<InventoryDetailTbl>();

    public virtual ICollection<InvoiceDetailTbl> InvoiceDetailTbls { get; set; } = new List<InvoiceDetailTbl>();

    public virtual ICollection<WarehouseCountingDetail> WarehouseCountingDetails { get; set; } = new List<WarehouseCountingDetail>();
}
