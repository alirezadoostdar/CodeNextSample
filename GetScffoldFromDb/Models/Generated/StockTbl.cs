using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class StockTbl
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

    public string? ImageName { get; set; }

    public bool NotReturn { get; set; }

    public string? Field1 { get; set; }

    public string? Field2 { get; set; }

    public string? Field3 { get; set; }

    public bool? HasPromotion { get; set; }

    public decimal BuyLastFee { get; set; }

    public bool IsUpdate { get; set; }

    public int? GroupId3 { get; set; }

    public int? CategoryId { get; set; }

    public bool SendToServer { get; set; }

    public decimal LastFeeNoCost { get; set; }

    public string? Field4 { get; set; }

    public string? Field5 { get; set; }

    public string? Located { get; set; }

    public long? IdTaxGov { get; set; }

    public int? SellerId { get; set; }

    public int? FkTaxUnitId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public DateTime? UpdateDateTime { get; set; }

    public bool CheckList { get; set; }

    public virtual ICollection<BarcodeTbl> BarcodeTbls { get; set; } = new List<BarcodeTbl>();

    public virtual GoodsCategoryTbl? Category { get; set; }

    public virtual ICollection<ConsumedGoodsTbl> ConsumedGoodsTbls { get; set; } = new List<ConsumedGoodsTbl>();

    public virtual TaxUnit? FkTaxUnit { get; set; }

    public virtual ICollection<GoodColorTbl> GoodColorTbls { get; set; } = new List<GoodColorTbl>();

    public virtual ICollection<GoodSizeTbl> GoodSizeTbls { get; set; } = new List<GoodSizeTbl>();

    public virtual ICollection<GoodVisitorTbl> GoodVisitorTbls { get; set; } = new List<GoodVisitorTbl>();

    public virtual ICollection<GoodWarehouseTbl> GoodWarehouseTbls { get; set; } = new List<GoodWarehouseTbl>();

    public virtual ICollection<GoodsImagesTbl> GoodsImagesTbls { get; set; } = new List<GoodsImagesTbl>();

    public virtual ICollection<GoodsQuotaTbl> GoodsQuotaTbls { get; set; } = new List<GoodsQuotaTbl>();

    public virtual StockGroup1Tbl? GroupId1Navigation { get; set; }

    public virtual StockGroup2Tbl? GroupId2Navigation { get; set; }

    public virtual StockGroup3Tbl? GroupId3Navigation { get; set; }

    public virtual ICollection<InventoryDetailTbl> InventoryDetailTbls { get; set; } = new List<InventoryDetailTbl>();

    public virtual ICollection<InvoiceDetailTbl> InvoiceDetailTblGoodSysCodeNavigations { get; set; } = new List<InvoiceDetailTbl>();

    public virtual ICollection<InvoiceDetailTbl> InvoiceDetailTblPromotionGoodSysCodeNavigations { get; set; } = new List<InvoiceDetailTbl>();

    public virtual ICollection<PricingDetailTbl> PricingDetailTbls { get; set; } = new List<PricingDetailTbl>();

    public virtual ICollection<PromotionTbl> PromotionTblFkMainGoodSysCodeNavigations { get; set; } = new List<PromotionTbl>();

    public virtual ICollection<PromotionTbl> PromotionTblFkPromotionGoodSysCodeNavigations { get; set; } = new List<PromotionTbl>();

    public virtual CodeMngdwntbl? Seller { get; set; }

    public virtual ICollection<TransferWareHoseDetailTbl> TransferWareHoseDetailTbls { get; set; } = new List<TransferWareHoseDetailTbl>();

    public virtual InfoGoodTypeTbl TypeNavigation { get; set; } = null!;

    public virtual ICollection<WarehouseCountingDetail> WarehouseCountingDetails { get; set; } = new List<WarehouseCountingDetail>();
}
