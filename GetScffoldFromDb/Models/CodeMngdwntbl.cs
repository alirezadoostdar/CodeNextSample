using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("CodeMNGDWNTbl")]
public partial class CodeMngdwntbl
{
    [Column("FK_AccountSysCode0")]
    public int FkAccountSysCode0 { get; set; }

    [Key]
    public int AccountSysCode { get; set; }

    public string Title { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal CreditLimit { get; set; }

    public int SecurLevel { get; set; }

    public bool? BedehkarOnly { get; set; }

    public bool IsUpdate { get; set; }

    [InverseProperty("FkAccoutnSysCodeNavigation")]
    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    [InverseProperty("FkAccountSyscodeNavigation")]
    public virtual BanksTbl? BanksTbl { get; set; }

    [InverseProperty("FkAccountSysCodeNavigation")]
    public virtual ICollection<BranchTbl> BranchTbls { get; set; } = new List<BranchTbl>();

    [InverseProperty("BelongtoNavigation")]
    public virtual ICollection<CheckInTbl> CheckInTbls { get; set; } = new List<CheckInTbl>();

    [InverseProperty("BelongtoNavigation")]
    public virtual ICollection<CheckOuttbl> CheckOuttbls { get; set; } = new List<CheckOuttbl>();

    [InverseProperty("FkAccountSyscodeNavigation")]
    public virtual CostTbl? CostTbl { get; set; }

    [InverseProperty("FkDistributorSysCodeNavigation")]
    public virtual ICollection<DistributionTbl> DistributionTblFkDistributorSysCodeNavigations { get; set; } = new List<DistributionTbl>();

    [InverseProperty("FkDriverSysCodeNavigation")]
    public virtual ICollection<DistributionTbl> DistributionTblFkDriverSysCodeNavigations { get; set; } = new List<DistributionTbl>();

    [InverseProperty("FkAccountSyscodeNavigation")]
    public virtual ICollection<DocDetailTbl> DocDetailTbls { get; set; } = new List<DocDetailTbl>();

    [ForeignKey("FkAccountSysCode0")]
    [InverseProperty("CodeMngdwntbls")]
    public virtual CodeMnguptbl FkAccountSysCode0Navigation { get; set; } = null!;

    [InverseProperty("BelongtoNavigation")]
    public virtual ICollection<GhestInTbl> GhestInTbls { get; set; } = new List<GhestInTbl>();

    [InverseProperty("AccountSysCodeNavigation")]
    public virtual ICollection<GoodVisitorTbl> GoodVisitorTbls { get; set; } = new List<GoodVisitorTbl>();

    [InverseProperty("FkAccountSysCodeNavigation")]
    public virtual ICollection<GoodsQuotaTbl> GoodsQuotaTbls { get; set; } = new List<GoodsQuotaTbl>();

    [InverseProperty("FkAccountSysCodeNavigation")]
    public virtual ICollection<InventoryTbl> InventoryTbls { get; set; } = new List<InventoryTbl>();

    [InverseProperty("FkAccountSysCodeNavigation")]
    public virtual ICollection<InvoiceTbl> InvoiceTblFkAccountSysCodeNavigations { get; set; } = new List<InvoiceTbl>();

    [InverseProperty("VisitorSyscodeNavigation")]
    public virtual ICollection<InvoiceTbl> InvoiceTblVisitorSyscodeNavigations { get; set; } = new List<InvoiceTbl>();

    [InverseProperty("AccountSysCodeNavigation")]
    public virtual ICollection<PartnersTbl> PartnersTbls { get; set; } = new List<PartnersTbl>();

    [InverseProperty("FkAccountSysCodeNavigation")]
    public virtual ICollection<PersonCreditDetailTbl> PersonCreditDetailTbls { get; set; } = new List<PersonCreditDetailTbl>();

    [InverseProperty("FkAccountsysCodeNavigation")]
    public virtual ICollection<PersonCreditTbl> PersonCreditTbls { get; set; } = new List<PersonCreditTbl>();

    [InverseProperty("FkAccountSysCodeNavigation")]
    public virtual PersonTbl? PersonTbl { get; set; }

    [InverseProperty("AccountCodeNavigation")]
    public virtual ICollection<PricingTbl> PricingTbls { get; set; } = new List<PricingTbl>();

    [ForeignKey("SecurLevel")]
    [InverseProperty("CodeMngdwntbls")]
    public virtual InfoSecurityLevelTbl SecurLevelNavigation { get; set; } = null!;

    [InverseProperty("Seller")]
    public virtual ICollection<StockTbl> StockTbls { get; set; } = new List<StockTbl>();

    [InverseProperty("FkAccountSysCodeNavigation")]
    public virtual ICollection<Visit> VisitFkAccountSysCodeNavigations { get; set; } = new List<Visit>();

    [InverseProperty("FkVisitorSysCodeNavigation")]
    public virtual ICollection<Visit> VisitFkVisitorSysCodeNavigations { get; set; } = new List<Visit>();

    [InverseProperty("FkVisitor")]
    public virtual ICollection<VisitScaduleTbl> VisitScaduleTbls { get; set; } = new List<VisitScaduleTbl>();
}
