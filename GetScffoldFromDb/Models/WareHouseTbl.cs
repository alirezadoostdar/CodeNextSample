using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class WareHouseTbl
{
    public string WareHouseName { get; set; } = null!;

    public int SysCode { get; set; }

    public virtual ICollection<GoodWarehouseTbl> GoodWarehouseTbls { get; set; } = new List<GoodWarehouseTbl>();

    public virtual ICollection<GoodsQuotaTbl> GoodsQuotaTbls { get; set; } = new List<GoodsQuotaTbl>();

    public virtual ICollection<InventoryDetailTbl> InventoryDetailTbls { get; set; } = new List<InventoryDetailTbl>();

    public virtual ICollection<InvoiceDetailTbl> InvoiceDetailTbls { get; set; } = new List<InvoiceDetailTbl>();

    public virtual ICollection<WarehouseCountingDetail> WarehouseCountingDetails { get; set; } = new List<WarehouseCountingDetail>();
}
