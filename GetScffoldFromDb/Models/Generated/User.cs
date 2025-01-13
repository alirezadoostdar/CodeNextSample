using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class User
{
    public string Uname { get; set; } = null!;

    public int Uid { get; set; }

    public int Gid { get; set; }

    public int SecureLevel { get; set; }

    public string PassWord { get; set; } = null!;

    public bool? Disable { get; set; }

    public bool? IsUpdateStockTbl { get; set; }

    public bool? IsUpdatePersonTblDocList { get; set; }

    public bool? IsUpdatePersonTblInvoiceList { get; set; }

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<DefaultPrintInfoLay> DefaultPrintInfoLays { get; set; } = new List<DefaultPrintInfoLay>();

    public virtual ICollection<DistributionTbl> DistributionTbls { get; set; } = new List<DistributionTbl>();

    public virtual ICollection<DocTbl> DocTbls { get; set; } = new List<DocTbl>();

    public virtual Group GidNavigation { get; set; } = null!;

    public virtual ICollection<InventoryTbl> InventoryTbls { get; set; } = new List<InventoryTbl>();

    public virtual ICollection<InvoiceTbl> InvoiceTbls { get; set; } = new List<InvoiceTbl>();

    public virtual ICollection<PersonCreditDetailTbl> PersonCreditDetailTbls { get; set; } = new List<PersonCreditDetailTbl>();

    public virtual ICollection<PricingTbl> PricingTbls { get; set; } = new List<PricingTbl>();

    public virtual ICollection<ScaduleCircuitTbl> ScaduleCircuitTblRecevieUsers { get; set; } = new List<ScaduleCircuitTbl>();

    public virtual ICollection<ScaduleCircuitTbl> ScaduleCircuitTblSendUsers { get; set; } = new List<ScaduleCircuitTbl>();

    public virtual ICollection<TaxInvoice> TaxInvoices { get; set; } = new List<TaxInvoice>();

    public virtual ICollection<TransferWareHoseTbl> TransferWareHoseTbls { get; set; } = new List<TransferWareHoseTbl>();
}
