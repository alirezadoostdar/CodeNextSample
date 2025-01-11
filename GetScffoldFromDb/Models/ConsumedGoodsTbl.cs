using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("ConsumedGoodsTBL")]
public partial class ConsumedGoodsTbl
{
    [Key]
    public int SysCode { get; set; }

    public int? GoodSysCode { get; set; }

    [Column("FK_ConsumedGoods")]
    public int? FkConsumedGoods { get; set; }

    [Column("QTY")]
    public double? Qty { get; set; }

    [ForeignKey("FkConsumedGoods")]
    [InverseProperty("ConsumedGoodsTbls")]
    public virtual StockTbl? FkConsumedGoodsNavigation { get; set; }
}
