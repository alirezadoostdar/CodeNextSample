using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwcompleteGood
{
    public int GoodSyscode { get; set; }

    [StringLength(1000)]
    public string Title { get; set; } = null!;

    [StringLength(100)]
    public string? Code { get; set; }

    [StringLength(100)]
    public string? BarCode { get; set; }

    [StringLength(1000)]
    public string? Type { get; set; }

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

    [StringLength(100)]
    public string? GroupName1 { get; set; }

    [StringLength(100)]
    public string? GroupName2 { get; set; }

    [StringLength(1000)]
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

    [Column("MaxQTY")]
    public float? MaxQty { get; set; }

    [Column(TypeName = "ntext")]
    public string? TechnicalBox { get; set; }

    [StringLength(1000)]
    public string? Field1 { get; set; }

    [StringLength(1000)]
    public string? Field2 { get; set; }

    [StringLength(1000)]
    public string? Field3 { get; set; }

    public bool NotReturn { get; set; }

    public bool IsCardDiscount { get; set; }

    public bool UnderSalePrice { get; set; }

    [Column("rtlTOlft")]
    public bool? RtlTolft { get; set; }

    public bool? HasPromotion { get; set; }

    [StringLength(1000)]
    public string? ImageName { get; set; }

    [Column(TypeName = "money")]
    public decimal BuyLastFee { get; set; }

    public bool IsUpdate { get; set; }

    [Column("GroupID3")]
    public int? GroupId3 { get; set; }

    [Column("CategoryID")]
    public int? CategoryId { get; set; }

    public bool SendToServer { get; set; }

    [StringLength(200)]
    public string? CategoryTitle { get; set; }

    [StringLength(100)]
    public string? GroupName3 { get; set; }

    [Column(TypeName = "money")]
    public decimal LastFeeNoCost { get; set; }

    [StringLength(200)]
    public string? Field4 { get; set; }

    [StringLength(200)]
    public string? Field5 { get; set; }

    [StringLength(200)]
    public string? Located { get; set; }

    public long? IdTaxGov { get; set; }

    public string? SellerName { get; set; }

    public double? InventoryRemain { get; set; }

    public bool CheckList { get; set; }
}
