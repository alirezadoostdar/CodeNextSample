using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class CodeMngdwntbl
{
    public int FkAccountSysCode0 { get; set; }

    public int AccountSysCode { get; set; }

    public string Title { get; set; } = null!;

    public decimal CreditLimit { get; set; }

    public int SecurLevel { get; set; }

    public bool? BedehkarOnly { get; set; }

    public bool IsUpdate { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual BanksTbl? BanksTbl { get; set; }

    public virtual ICollection<BranchTbl> BranchTbls { get; set; } = new List<BranchTbl>();

    public virtual ICollection<CheckInTbl> CheckInTbls { get; set; } = new List<CheckInTbl>();

    public virtual ICollection<CheckOuttbl> CheckOuttbls { get; set; } = new List<CheckOuttbl>();

    public virtual CostTbl? CostTbl { get; set; }

    public virtual ICollection<DistributionTbl> DistributionTblFkDistributorSysCodeNavigations { get; set; } = new List<DistributionTbl>();

    public virtual ICollection<DistributionTbl> DistributionTblFkDriverSysCodeNavigations { get; set; } = new List<DistributionTbl>();

    public virtual ICollection<DocDetailTbl> DocDetailTbls { get; set; } = new List<DocDetailTbl>();

    public virtual CodeMnguptbl FkAccountSysCode0Navigation { get; set; } = null!;

    public virtual ICollection<GhestInTbl> GhestInTbls { get; set; } = new List<GhestInTbl>();

    public virtual ICollection<GoodVisitorTbl> GoodVisitorTbls { get; set; } = new List<GoodVisitorTbl>();

    public virtual ICollection<GoodsQuotaTbl> GoodsQuotaTbls { get; set; } = new List<GoodsQuotaTbl>();

    public virtual ICollection<InventoryTbl> InventoryTbls { get; set; } = new List<InventoryTbl>();

    public virtual ICollection<InvoiceTbl> InvoiceTblFkAccountSysCodeNavigations { get; set; } = new List<InvoiceTbl>();

    public virtual ICollection<InvoiceTbl> InvoiceTblVisitorSyscodeNavigations { get; set; } = new List<InvoiceTbl>();

    public virtual ICollection<PartnersTbl> PartnersTbls { get; set; } = new List<PartnersTbl>();

    public virtual ICollection<PersonCreditDetailTbl> PersonCreditDetailTbls { get; set; } = new List<PersonCreditDetailTbl>();

    public virtual ICollection<PersonCreditTbl> PersonCreditTbls { get; set; } = new List<PersonCreditTbl>();

    public virtual PersonTbl? PersonTbl { get; set; }

    public virtual ICollection<PricingTbl> PricingTbls { get; set; } = new List<PricingTbl>();

    public virtual InfoSecurityLevelTbl SecurLevelNavigation { get; set; } = null!;

    public virtual ICollection<StockTbl> StockTbls { get; set; } = new List<StockTbl>();

    public virtual ICollection<Visit> VisitFkAccountSysCodeNavigations { get; set; } = new List<Visit>();

    public virtual ICollection<Visit> VisitFkVisitorSysCodeNavigations { get; set; } = new List<Visit>();

    public virtual ICollection<VisitScaduleTbl> VisitScaduleTbls { get; set; } = new List<VisitScaduleTbl>();
}
