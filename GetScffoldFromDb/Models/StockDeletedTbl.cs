using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class StockDeletedTbl
{
    public int GoodSyscode { get; set; }

    public string Title { get; set; } = null!;

    public string? Code { get; set; }

    public string? BarCode { get; set; }

    public int Type { get; set; }

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

    public int? GroupId1 { get; set; }

    public int? GroupId2 { get; set; }

    public bool SerialNo { get; set; }

    public float Weight { get; set; }

    public string Term { get; set; } = null!;

    public double MaliatArzeshAfzoodeh { get; set; }

    public bool DateExpire { get; set; }

    public double Avarez { get; set; }

    public int Alarm { get; set; }

    public string? TechnicalBox { get; set; }

    public float? MaxQty { get; set; }

    public bool? RtlTolft { get; set; }

    public bool UnderSalePrice { get; set; }

    public bool IsCardDiscount { get; set; }

    public bool NotReturn { get; set; }

    public string? Field1 { get; set; }

    public string? Field2 { get; set; }

    public string? Field3 { get; set; }

    public bool? HasPromotion { get; set; }

    public string? ImageName { get; set; }

    public decimal BuyLastFee { get; set; }

    public bool DeletedOnServer { get; set; }
}
