using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("GoodsQuotaTBL")]
public partial class GoodsQuotaTbl
{
    [Key]
    public int SysCode { get; set; }

    [Column("FK_GoodSysCode")]
    public int FkGoodSysCode { get; set; }

    [Column("FK_WareHouseID")]
    public int? FkWareHouseId { get; set; }

    [Column("FK_AccountSysCode")]
    public int FkAccountSysCode { get; set; }

    public double Quantity { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SartDateShamsi { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? EndDateShamsi { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDateMiladi { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDateMiladi { get; set; }

    [ForeignKey("FkAccountSysCode")]
    [InverseProperty("GoodsQuotaTbls")]
    public virtual CodeMngdwntbl FkAccountSysCodeNavigation { get; set; } = null!;

    [ForeignKey("FkGoodSysCode")]
    [InverseProperty("GoodsQuotaTbls")]
    public virtual StockTbl FkGoodSysCodeNavigation { get; set; } = null!;

    [ForeignKey("FkWareHouseId")]
    [InverseProperty("GoodsQuotaTbls")]
    public virtual WareHouseTbl? FkWareHouse { get; set; }
}
