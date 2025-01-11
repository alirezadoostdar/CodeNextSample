using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("StockDeletedTbl")]
public partial class StockDeletedTbl
{
    public int GoodSyscode { get; set; }

    [StringLength(1000)]
    public string Title { get; set; } = null!;

    [StringLength(100)]
    public string? Code { get; set; }

    [StringLength(100)]
    public string? BarCode { get; set; }

    public int Type { get; set; }

    [StringLength(100)]
    public string FstUnit { get; set; } = null!;

    [StringLength(100)]
    public string SecUnit { get; set; } = null!;

    public double? UnitRate { get; set; }

    public float OrderPoint { get; set; }

    [Column(TypeName = "money")]
    public decimal SalePrice1 { get; set; }

    [Column(TypeName = "money")]
    public decimal SalePrice2 { get; set; }

    [Column(TypeName = "money")]
    public decimal SalePrice3 { get; set; }

    [Column(TypeName = "money")]
    public decimal SalePrice4 { get; set; }

    [Column(TypeName = "money")]
    public decimal SalePrice5 { get; set; }

    public double? VisitorPer { get; set; }

    [StringLength(300)]
    public string Comment { get; set; } = null!;

    public double? DiscontPer { get; set; }

    [Column(TypeName = "money")]
    public decimal UserPrice { get; set; }

    [Column("GroupID1")]
    public int? GroupId1 { get; set; }

    [Column("GroupID2")]
    public int? GroupId2 { get; set; }

    public bool SerialNo { get; set; }

    public float Weight { get; set; }

    [StringLength(1000)]
    public string Term { get; set; } = null!;

    public double MaliatArzeshAfzoodeh { get; set; }

    public bool DateExpire { get; set; }

    public double Avarez { get; set; }

    public int Alarm { get; set; }

    [Column(TypeName = "ntext")]
    public string? TechnicalBox { get; set; }

    [Column("MaxQTY")]
    public float? MaxQty { get; set; }

    [Column("rtlTOlft")]
    public bool? RtlTolft { get; set; }

    public bool UnderSalePrice { get; set; }

    public bool IsCardDiscount { get; set; }

    public bool NotReturn { get; set; }

    [StringLength(1000)]
    public string? Field1 { get; set; }

    [StringLength(1000)]
    public string? Field2 { get; set; }

    [StringLength(1000)]
    public string? Field3 { get; set; }

    public bool? HasPromotion { get; set; }

    [StringLength(1000)]
    public string? ImageName { get; set; }

    [Column(TypeName = "money")]
    public decimal BuyLastFee { get; set; }

    public bool DeletedOnServer { get; set; }
}
