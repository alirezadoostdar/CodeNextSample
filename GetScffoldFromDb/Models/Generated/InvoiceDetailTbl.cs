using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class InvoiceDetailTbl
{
    public int GoodSysCode { get; set; }

    public string? Comment { get; set; }

    public double? Quantity { get; set; }

    public decimal Fee { get; set; }

    public string Unit { get; set; } = null!;

    public double? UnitRate { get; set; }

    public decimal? UserPrice { get; set; }

    public string? SerialNo { get; set; }

    public int? Size { get; set; }

    public int? Color { get; set; }

    public int? WareHouse { get; set; }

    public int FkInvoiceSysCode { get; set; }

    public double? DiscountPercent { get; set; }

    public int SysCode { get; set; }

    public string? Term { get; set; }

    public int? RowNo { get; set; }

    public double? DiscountPercent2 { get; set; }

    public double MaliatArzeshAfzoodeh { get; set; }

    public double Avarez { get; set; }

    public string? DateExpire { get; set; }

    public decimal? CurFee { get; set; }

    public decimal DiscountFee { get; set; }

    public int? VisitorSysCode { get; set; }

    public decimal Cost { get; set; }

    public decimal VisitorFee { get; set; }

    public float? VisitorPer { get; set; }

    public double? WeightCar { get; set; }

    public double? WeighCarwithBar { get; set; }

    public decimal BenefitCost { get; set; }

    public int? PromotionGoodSysCode { get; set; }

    public virtual GoodColorTbl? ColorNavigation { get; set; }

    public virtual InvoiceTbl FkInvoiceSysCodeNavigation { get; set; } = null!;

    public virtual StockTbl GoodSysCodeNavigation { get; set; } = null!;

    public virtual StockTbl? PromotionGoodSysCodeNavigation { get; set; }

    public virtual GoodSizeTbl? SizeNavigation { get; set; }

    public virtual WareHouseTbl? WareHouseNavigation { get; set; }
}
