using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("TransferWareHoseDetailTbl")]
public partial class TransferWareHoseDetailTbl
{
    public int GoodSysCode { get; set; }

    [StringLength(300)]
    public string? Comment { get; set; }

    public double? Quantity { get; set; }

    [StringLength(100)]
    public string Unit { get; set; } = null!;

    public double? UnitRate { get; set; }

    [StringLength(100)]
    public string? SerialNo { get; set; }

    public int? Size { get; set; }

    public int? Color { get; set; }

    public int? WareHouseFrom { get; set; }

    public int? WareHouseTo { get; set; }

    [Column("FK_TransferSysCode")]
    public int FkTransferSysCode { get; set; }

    [Key]
    public int SysCode { get; set; }

    public int? RowNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DateExpire { get; set; }

    [ForeignKey("FkTransferSysCode")]
    [InverseProperty("TransferWareHoseDetailTbls")]
    public virtual TransferWareHoseTbl FkTransferSysCodeNavigation { get; set; } = null!;

    [ForeignKey("GoodSysCode")]
    [InverseProperty("TransferWareHoseDetailTbls")]
    public virtual StockTbl GoodSysCodeNavigation { get; set; } = null!;
}
