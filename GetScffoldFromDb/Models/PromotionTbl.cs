using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("PromotionTBL")]
public partial class PromotionTbl
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("FK_MainGoodSysCode")]
    public int? FkMainGoodSysCode { get; set; }

    [Column("FK_PromotionGoodSysCode")]
    public int? FkPromotionGoodSysCode { get; set; }

    public double BuyQuantity { get; set; }

    public double PromotionQuantity { get; set; }

    public bool? IsLoop { get; set; }

    [ForeignKey("FkMainGoodSysCode")]
    [InverseProperty("PromotionTblFkMainGoodSysCodeNavigations")]
    public virtual StockTbl? FkMainGoodSysCodeNavigation { get; set; }

    [ForeignKey("FkPromotionGoodSysCode")]
    [InverseProperty("PromotionTblFkPromotionGoodSysCodeNavigations")]
    public virtual StockTbl? FkPromotionGoodSysCodeNavigation { get; set; }
}
