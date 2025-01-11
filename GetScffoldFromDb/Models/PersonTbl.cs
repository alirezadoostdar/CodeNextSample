using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class PersonTbl
{
    public int FkAccountSysCode { get; set; }

    public int? GroupId1 { get; set; }

    public int? GroupId2 { get; set; }

    public float VisitorPer { get; set; }

    public string Comment { get; set; } = null!;

    public string Introducer { get; set; } = null!;

    public long? Code { get; set; }

    public int SalePriceNo { get; set; }

    public int? ContactId { get; set; }

    public int? VisitorCostAcc { get; set; }

    public decimal? VisitorBaseAmmount { get; set; }

    public decimal? VisitorIncreaseAmmount { get; set; }

    public float? VisitorIncreasePer { get; set; }

    public bool VisitorAutoDoc { get; set; }

    public short VisitorGoodActiveStat { get; set; }

    public bool VisitorPerActiveStat { get; set; }

    public int? VisitorGoodGroupCode { get; set; }

    public int? FkIdkind { get; set; }

    public bool? OutSidePerson { get; set; }

    public float? VisitorPerChanging { get; set; }

    public string? ShopName { get; set; }

    public string? Cardno { get; set; }

    public string? CardId1 { get; set; }

    public string? CardId2 { get; set; }

    public string? BirthDayDate { get; set; }

    public string? Pass { get; set; }

    public decimal? Credit { get; set; }

    public int? FkPersonCutomerKind { get; set; }

    public int? FkPersonCommercial { get; set; }

    public string? Resume { get; set; }

    public string? ShippComment { get; set; }

    public int? Visitor1SysCode { get; set; }

    public int? Visitor2SysCode { get; set; }

    public int? VisitorColor { get; set; }

    public bool? IsDriver { get; set; }

    public bool? IsDistributor { get; set; }

    public bool? IsEmployee { get; set; }

    public bool IsUpdate { get; set; }

    public byte? FkTaxPersonKindId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public DateTime? UpdateDateTime { get; set; }

    public string? EShopId { get; set; }

    public virtual TelBook? Contact { get; set; }

    public virtual CodeMngdwntbl FkAccountSysCodeNavigation { get; set; } = null!;

    public virtual PersonKind? FkIdkindNavigation { get; set; }

    public virtual PersonCommercialTbl? FkPersonCommercialNavigation { get; set; }

    public virtual PersonCustomerKindTbl? FkPersonCutomerKindNavigation { get; set; }

    public virtual TaxPersonKind? FkTaxPersonKind { get; set; }

    public virtual ICollection<GoodsGroup1PersonAccountTbl> GoodsGroup1PersonAccountTbls { get; set; } = new List<GoodsGroup1PersonAccountTbl>();

    public virtual ICollection<GoodsGroup2PersonAccountTbl> GoodsGroup2PersonAccountTbls { get; set; } = new List<GoodsGroup2PersonAccountTbl>();

    public virtual PersonGroup1Tbl? GroupId1Navigation { get; set; }

    public virtual PersonGroup2Tbl? GroupId2Navigation { get; set; }

    public virtual ICollection<InventoryTbl> InventoryTblFkDistributorSysCodeNavigations { get; set; } = new List<InventoryTbl>();

    public virtual ICollection<InventoryTbl> InventoryTblFkDriversSysCodeNavigations { get; set; } = new List<InventoryTbl>();

    public virtual InfoPersonPriceNoTbl SalePriceNoNavigation { get; set; } = null!;
}
