using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("StockTbl")]
public partial class StockTbl
{
    [Key]
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

    [StringLength(1000)]
    public string? ImageName { get; set; }

    public bool NotReturn { get; set; }

    [StringLength(1000)]
    public string? Field1 { get; set; }

    [StringLength(1000)]
    public string? Field2 { get; set; }

    [StringLength(1000)]
    public string? Field3 { get; set; }

    public bool? HasPromotion { get; set; }

    [Column(TypeName = "money")]
    public decimal BuyLastFee { get; set; }

    public bool IsUpdate { get; set; }

    [Column("GroupID3")]
    public int? GroupId3 { get; set; }

    [Column("CategoryID")]
    public int? CategoryId { get; set; }

    public bool SendToServer { get; set; }

    [Column(TypeName = "money")]
    public decimal LastFeeNoCost { get; set; }

    [StringLength(200)]
    public string? Field4 { get; set; }

    [StringLength(200)]
    public string? Field5 { get; set; }

    [StringLength(200)]
    public string? Located { get; set; }

    public long? IdTaxGov { get; set; }

    public int? SellerId { get; set; }

    [Column("Fk_TaxUnitId")]
    public int? FkTaxUnitId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDateTime { get; set; }

    public bool CheckList { get; set; }

    [InverseProperty("GoodCodeNavigation")]
    public virtual ICollection<BarcodeTbl> BarcodeTbls { get; set; } = new List<BarcodeTbl>();

    [ForeignKey("CategoryId")]
    [InverseProperty("StockTbls")]
    public virtual GoodsCategoryTbl? Category { get; set; }

    [InverseProperty("FkConsumedGoodsNavigation")]
    public virtual ICollection<ConsumedGoodsTbl> ConsumedGoodsTbls { get; set; } = new List<ConsumedGoodsTbl>();

    [ForeignKey("FkTaxUnitId")]
    [InverseProperty("StockTbls")]
    public virtual TaxUnit? FkTaxUnit { get; set; }

    [InverseProperty("GoodSysCodeNavigation")]
    public virtual ICollection<GoodColorTbl> GoodColorTbls { get; set; } = new List<GoodColorTbl>();

    [InverseProperty("GoodSysCodeNavigation")]
    public virtual ICollection<GoodSizeTbl> GoodSizeTbls { get; set; } = new List<GoodSizeTbl>();

    [InverseProperty("GoodSysCodeNavigation")]
    public virtual ICollection<GoodVisitorTbl> GoodVisitorTbls { get; set; } = new List<GoodVisitorTbl>();

    [InverseProperty("GoodSysCodeNavigation")]
    public virtual ICollection<GoodWarehouseTbl> GoodWarehouseTbls { get; set; } = new List<GoodWarehouseTbl>();

    [InverseProperty("FkGoodSysCodeNavigation")]
    public virtual ICollection<GoodsImagesTbl> GoodsImagesTbls { get; set; } = new List<GoodsImagesTbl>();

    [InverseProperty("FkGoodSysCodeNavigation")]
    public virtual ICollection<GoodsQuotaTbl> GoodsQuotaTbls { get; set; } = new List<GoodsQuotaTbl>();

    [ForeignKey("GroupId1")]
    [InverseProperty("StockTbls")]
    public virtual StockGroup1Tbl? GroupId1Navigation { get; set; }

    [ForeignKey("GroupId2")]
    [InverseProperty("StockTbls")]
    public virtual StockGroup2Tbl? GroupId2Navigation { get; set; }

    [ForeignKey("GroupId3")]
    [InverseProperty("StockTbls")]
    public virtual StockGroup3Tbl? GroupId3Navigation { get; set; }

    [InverseProperty("GoodSysCodeNavigation")]
    public virtual ICollection<InventoryDetailTbl> InventoryDetailTbls { get; set; } = new List<InventoryDetailTbl>();

    [InverseProperty("GoodSysCodeNavigation")]
    public virtual ICollection<InvoiceDetailTbl> InvoiceDetailTblGoodSysCodeNavigations { get; set; } = new List<InvoiceDetailTbl>();

    [InverseProperty("PromotionGoodSysCodeNavigation")]
    public virtual ICollection<InvoiceDetailTbl> InvoiceDetailTblPromotionGoodSysCodeNavigations { get; set; } = new List<InvoiceDetailTbl>();

    [InverseProperty("GoodSysCodeNavigation")]
    public virtual ICollection<PricingDetailTbl> PricingDetailTbls { get; set; } = new List<PricingDetailTbl>();

    [InverseProperty("FkMainGoodSysCodeNavigation")]
    public virtual ICollection<PromotionTbl> PromotionTblFkMainGoodSysCodeNavigations { get; set; } = new List<PromotionTbl>();

    [InverseProperty("FkPromotionGoodSysCodeNavigation")]
    public virtual ICollection<PromotionTbl> PromotionTblFkPromotionGoodSysCodeNavigations { get; set; } = new List<PromotionTbl>();

    [ForeignKey("SellerId")]
    [InverseProperty("StockTbls")]
    public virtual CodeMngdwntbl? Seller { get; set; }

    [InverseProperty("GoodSysCodeNavigation")]
    public virtual ICollection<TransferWareHoseDetailTbl> TransferWareHoseDetailTbls { get; set; } = new List<TransferWareHoseDetailTbl>();

    [ForeignKey("Type")]
    [InverseProperty("StockTbls")]
    public virtual InfoGoodTypeTbl TypeNavigation { get; set; } = null!;

    [InverseProperty("GoodSysCodeNavigation")]
    public virtual ICollection<WarehouseCountingDetail> WarehouseCountingDetails { get; set; } = new List<WarehouseCountingDetail>();
}
