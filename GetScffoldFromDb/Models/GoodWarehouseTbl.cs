using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("GoodWarehouseTBL")]
public partial class GoodWarehouseTbl
{
    [Key]
    public int SysCode { get; set; }

    public int WareHouseSysCode { get; set; }

    public int GoodSysCode { get; set; }

    public int OrderPoint { get; set; }

    [Column("MaxQTY")]
    public int MaxQty { get; set; }

    [ForeignKey("GoodSysCode")]
    [InverseProperty("GoodWarehouseTbls")]
    public virtual StockTbl GoodSysCodeNavigation { get; set; } = null!;

    [ForeignKey("WareHouseSysCode")]
    [InverseProperty("GoodWarehouseTbls")]
    public virtual WareHouseTbl WareHouseSysCodeNavigation { get; set; } = null!;
}
