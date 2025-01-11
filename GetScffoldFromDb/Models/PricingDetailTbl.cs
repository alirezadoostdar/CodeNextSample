using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("PricingDetailTBL")]
public partial class PricingDetailTbl
{
    [Key]
    public int SysCode { get; set; }

    [Column("Fk_PricingID")]
    public int? FkPricingId { get; set; }

    public int? GoodSysCode { get; set; }

    [Column(TypeName = "money")]
    public decimal? Fee { get; set; }

    public double? DiscountPer { get; set; }

    public double? LastDiscountPer { get; set; }

    public double? SalePrice1Per { get; set; }

    public double? SalePrice2Per { get; set; }

    public double? SalePrice3Per { get; set; }

    public double? SalePrice4Per { get; set; }

    public double? SalePrice5Per { get; set; }

    [Column(TypeName = "money")]
    public decimal? SalePrice1 { get; set; }

    [Column(TypeName = "money")]
    public decimal? SalePrice2 { get; set; }

    [Column(TypeName = "money")]
    public decimal? SalePrice3 { get; set; }

    [Column(TypeName = "money")]
    public decimal? SalePrice4 { get; set; }

    [Column(TypeName = "money")]
    public decimal? SalePrice5 { get; set; }

    [StringLength(1000)]
    public string Comment { get; set; } = null!;

    public int TasviehDay { get; set; }

    [Column("RowNO")]
    public int RowNo { get; set; }

    [ForeignKey("FkPricingId")]
    [InverseProperty("PricingDetailTbls")]
    public virtual PricingTbl? FkPricing { get; set; }

    [ForeignKey("GoodSysCode")]
    [InverseProperty("PricingDetailTbls")]
    public virtual StockTbl? GoodSysCodeNavigation { get; set; }
}
