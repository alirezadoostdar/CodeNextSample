using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("PersonTbl")]
public partial class PersonTbl
{
    [Key]
    [Column("FK_AccountSysCode")]
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

    [Column(TypeName = "money")]
    public decimal? VisitorBaseAmmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? VisitorIncreaseAmmount { get; set; }

    public float? VisitorIncreasePer { get; set; }

    public bool VisitorAutoDoc { get; set; }

    public short VisitorGoodActiveStat { get; set; }

    public bool VisitorPerActiveStat { get; set; }

    public int? VisitorGoodGroupCode { get; set; }

    [Column("FK_IDKind")]
    public int? FkIdkind { get; set; }

    public bool? OutSidePerson { get; set; }

    public float? VisitorPerChanging { get; set; }

    public string? ShopName { get; set; }

    public string? Cardno { get; set; }

    [Column("CardID1")]
    public string? CardId1 { get; set; }

    [Column("CardID2")]
    public string? CardId2 { get; set; }

    [Column("birthDayDate")]
    [StringLength(10)]
    public string? BirthDayDate { get; set; }

    public string? Pass { get; set; }

    [Column(TypeName = "money")]
    public decimal? Credit { get; set; }

    [Column("FK_PersonCutomerKind")]
    public int? FkPersonCutomerKind { get; set; }

    [Column("FK_PersonCommercial")]
    public int? FkPersonCommercial { get; set; }

    [Column(TypeName = "ntext")]
    public string? Resume { get; set; }

    public string? ShippComment { get; set; }

    public int? Visitor1SysCode { get; set; }

    public int? Visitor2SysCode { get; set; }

    public int? VisitorColor { get; set; }

    public bool? IsDriver { get; set; }

    public bool? IsDistributor { get; set; }

    public bool? IsEmployee { get; set; }

    public bool IsUpdate { get; set; }

    [Column("Fk_TaxPersonKindId")]
    public byte? FkTaxPersonKindId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDateTime { get; set; }

    [Column("eShopId")]
    [StringLength(200)]
    public string? EShopId { get; set; }

    [ForeignKey("ContactId")]
    [InverseProperty("PersonTbls")]
    public virtual TelBook? Contact { get; set; }

    [ForeignKey("FkAccountSysCode")]
    [InverseProperty("PersonTbl")]
    public virtual CodeMngdwntbl FkAccountSysCodeNavigation { get; set; } = null!;

    [ForeignKey("FkIdkind")]
    [InverseProperty("PersonTbls")]
    public virtual PersonKind? FkIdkindNavigation { get; set; }

    [ForeignKey("FkPersonCommercial")]
    [InverseProperty("PersonTbls")]
    public virtual PersonCommercialTbl? FkPersonCommercialNavigation { get; set; }

    [ForeignKey("FkPersonCutomerKind")]
    [InverseProperty("PersonTbls")]
    public virtual PersonCustomerKindTbl? FkPersonCutomerKindNavigation { get; set; }

    [ForeignKey("FkTaxPersonKindId")]
    [InverseProperty("PersonTbls")]
    public virtual TaxPersonKind? FkTaxPersonKind { get; set; }

    [InverseProperty("AccountSysCodeNavigation")]
    public virtual ICollection<GoodsGroup1PersonAccountTbl> GoodsGroup1PersonAccountTbls { get; set; } = new List<GoodsGroup1PersonAccountTbl>();

    [InverseProperty("AccountSysCodeNavigation")]
    public virtual ICollection<GoodsGroup2PersonAccountTbl> GoodsGroup2PersonAccountTbls { get; set; } = new List<GoodsGroup2PersonAccountTbl>();

    [ForeignKey("GroupId1")]
    [InverseProperty("PersonTbls")]
    public virtual PersonGroup1Tbl? GroupId1Navigation { get; set; }

    [ForeignKey("GroupId2")]
    [InverseProperty("PersonTbls")]
    public virtual PersonGroup2Tbl? GroupId2Navigation { get; set; }

    [InverseProperty("FkDistributorSysCodeNavigation")]
    public virtual ICollection<InventoryTbl> InventoryTblFkDistributorSysCodeNavigations { get; set; } = new List<InventoryTbl>();

    [InverseProperty("FkDriversSysCodeNavigation")]
    public virtual ICollection<InventoryTbl> InventoryTblFkDriversSysCodeNavigations { get; set; } = new List<InventoryTbl>();

    [ForeignKey("SalePriceNo")]
    [InverseProperty("PersonTbls")]
    public virtual InfoPersonPriceNoTbl SalePriceNoNavigation { get; set; } = null!;
}
