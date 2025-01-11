using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("GoodsImagesTBL")]
public partial class GoodsImagesTbl
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(100)]
    public string ImageName { get; set; } = null!;

    [Column(TypeName = "image")]
    public byte[] Images { get; set; } = null!;

    [Column("FK_GoodSysCode")]
    public int FkGoodSysCode { get; set; }

    [ForeignKey("FkGoodSysCode")]
    [InverseProperty("GoodsImagesTbls")]
    public virtual StockTbl FkGoodSysCodeNavigation { get; set; } = null!;
}
