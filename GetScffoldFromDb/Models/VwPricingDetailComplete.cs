using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwPricingDetailComplete
{
    public int PricingNo { get; set; }

    public string ShamsiDate { get; set; } = null!;

    public DateTime MiladiDate { get; set; }

    public string? SysShamsiDate { get; set; }

    public DateTime? SysMiladiDate { get; set; }

    public int UserNo { get; set; }

    public int? AccountCode { get; set; }

    public string Comment { get; set; } = null!;

    public int SysCode { get; set; }

    public int? FkPricingId { get; set; }

    public int? GoodSysCode { get; set; }

    public decimal? Fee { get; set; }

    public double? DiscountPer { get; set; }

    public double? LastDiscountPer { get; set; }

    public double? SalePrice1Per { get; set; }

    public double? SalePrice2Per { get; set; }

    public double? SalePrice3Per { get; set; }

    public double? SalePrice4Per { get; set; }

    public double? SalePrice5Per { get; set; }

    public decimal? SalePrice1 { get; set; }

    public decimal? SalePrice2 { get; set; }

    public decimal? SalePrice3 { get; set; }

    public decimal? SalePrice4 { get; set; }

    public decimal? SalePrice5 { get; set; }

    public string CommentRow { get; set; } = null!;

    public int TasviehDayRow { get; set; }

    public string Field1 { get; set; } = null!;

    public string Field2 { get; set; } = null!;

    public string Field3 { get; set; } = null!;

    public int TasviehDay { get; set; }

    public int PricingSerial { get; set; }

    public string? Title { get; set; }

    public string GoodTitle { get; set; } = null!;

    public string Uname { get; set; } = null!;
}
