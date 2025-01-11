using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwPricingDetailComplete
{
    public int PricingNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ShamsiDate { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime MiladiDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SysShamsiDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SysMiladiDate { get; set; }

    public int UserNo { get; set; }

    public int? AccountCode { get; set; }

    [StringLength(2000)]
    public string Comment { get; set; } = null!;

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
    public string CommentRow { get; set; } = null!;

    public int TasviehDayRow { get; set; }

    [StringLength(1000)]
    public string Field1 { get; set; } = null!;

    [StringLength(1000)]
    public string Field2 { get; set; } = null!;

    [StringLength(1000)]
    public string Field3 { get; set; } = null!;

    public int TasviehDay { get; set; }

    public int PricingSerial { get; set; }

    public string? Title { get; set; }

    [StringLength(1000)]
    public string GoodTitle { get; set; } = null!;

    [Column("UName")]
    [StringLength(1000)]
    public string Uname { get; set; } = null!;
}
