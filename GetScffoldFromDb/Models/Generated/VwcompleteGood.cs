using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VwcompleteGood
{
    public int GoodSyscode { get; set; }

    public string Title { get; set; } = null!;

    public string? Code { get; set; }

    public string? BarCode { get; set; }

    public string? Type { get; set; }

    public string FstUnit { get; set; } = null!;

    public string SecUnit { get; set; } = null!;

    public double? UnitRate { get; set; }

    public float OrderPoint { get; set; }

    public decimal SalePrice1 { get; set; }

    public decimal SalePrice2 { get; set; }

    public decimal SalePrice3 { get; set; }

    public decimal SalePrice4 { get; set; }

    public decimal SalePrice5 { get; set; }

    public double? VisitorPer { get; set; }

    public string Comment { get; set; } = null!;

    public double? DiscontPer { get; set; }

    public decimal UserPrice { get; set; }

    public string? GroupName1 { get; set; }

    public string? GroupName2 { get; set; }

    public string Term { get; set; } = null!;

    public float Weight { get; set; }

    public bool SerialNo { get; set; }

    public int TypeId { get; set; }

    public int? GroupId1 { get; set; }

    public int? GroupId2 { get; set; }

    public double MaliatArzeshAfzoodeh { get; set; }

    public bool DateExpire { get; set; }

    public double Avarez { get; set; }

    public int Alarm { get; set; }

    public float? MaxQty { get; set; }

    public string? TechnicalBox { get; set; }

    public string? Field1 { get; set; }

    public string? Field2 { get; set; }

    public string? Field3 { get; set; }

    public bool NotReturn { get; set; }

    public bool IsCardDiscount { get; set; }

    public bool UnderSalePrice { get; set; }

    public bool? RtlTolft { get; set; }

    public bool? HasPromotion { get; set; }

    public string? ImageName { get; set; }

    public decimal BuyLastFee { get; set; }

    public bool IsUpdate { get; set; }

    public int? GroupId3 { get; set; }

    public int? CategoryId { get; set; }

    public bool SendToServer { get; set; }

    public string? CategoryTitle { get; set; }

    public string? GroupName3 { get; set; }

    public decimal LastFeeNoCost { get; set; }

    public string? Field4 { get; set; }

    public string? Field5 { get; set; }

    public string? Located { get; set; }

    public long? IdTaxGov { get; set; }

    public string? SellerName { get; set; }

    public double? InventoryRemain { get; set; }

    public bool CheckList { get; set; }
}
