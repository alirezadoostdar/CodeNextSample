using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class PricingDetailTbl
{
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

    public string Comment { get; set; } = null!;

    public int TasviehDay { get; set; }

    public int RowNo { get; set; }

    public virtual PricingTbl? FkPricing { get; set; }

    public virtual StockTbl? GoodSysCodeNavigation { get; set; }
}
