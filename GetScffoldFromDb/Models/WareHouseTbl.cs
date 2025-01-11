using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("WareHouseTbl")]
public partial class WareHouseTbl
{
    [StringLength(1000)]
    public string WareHouseName { get; set; } = null!;

    [Key]
    public int SysCode { get; set; }

    [InverseProperty("WareHouseSysCodeNavigation")]
    public virtual ICollection<GoodWarehouseTbl> GoodWarehouseTbls { get; set; } = new List<GoodWarehouseTbl>();

    [InverseProperty("FkWareHouse")]
    public virtual ICollection<GoodsQuotaTbl> GoodsQuotaTbls { get; set; } = new List<GoodsQuotaTbl>();

    [InverseProperty("WareHouseNavigation")]
    public virtual ICollection<InventoryDetailTbl> InventoryDetailTbls { get; set; } = new List<InventoryDetailTbl>();

    [InverseProperty("WareHouseNavigation")]
    public virtual ICollection<InvoiceDetailTbl> InvoiceDetailTbls { get; set; } = new List<InvoiceDetailTbl>();

    [InverseProperty("WarehouseNavigation")]
    public virtual ICollection<WarehouseCountingDetail> WarehouseCountingDetails { get; set; } = new List<WarehouseCountingDetail>();
}
