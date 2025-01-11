using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

public partial class User
{
    [Column("UName")]
    [StringLength(1000)]
    public string Uname { get; set; } = null!;

    [Key]
    [Column("UID")]
    public int Uid { get; set; }

    [Column("GID")]
    public int Gid { get; set; }

    public int SecureLevel { get; set; }

    [StringLength(4000)]
    public string PassWord { get; set; } = null!;

    public bool? Disable { get; set; }

    public bool? IsUpdateStockTbl { get; set; }

    [Column("IsUpdatePersonTbl_DocList")]
    public bool? IsUpdatePersonTblDocList { get; set; }

    [Column("IsUpdatePersonTbl_InvoiceList")]
    public bool? IsUpdatePersonTblInvoiceList { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<DefaultPrintInfoLay> DefaultPrintInfoLays { get; set; } = new List<DefaultPrintInfoLay>();

    [InverseProperty("UserNoNavigation")]
    public virtual ICollection<DistributionTbl> DistributionTbls { get; set; } = new List<DistributionTbl>();

    [InverseProperty("UserIdnoNavigation")]
    public virtual ICollection<DocTbl> DocTbls { get; set; } = new List<DocTbl>();

    [ForeignKey("Gid")]
    [InverseProperty("Users")]
    public virtual Group GidNavigation { get; set; } = null!;

    [InverseProperty("UserNoNavigation")]
    public virtual ICollection<InventoryTbl> InventoryTbls { get; set; } = new List<InventoryTbl>();

    [InverseProperty("UserNoNavigation")]
    public virtual ICollection<InvoiceTbl> InvoiceTbls { get; set; } = new List<InvoiceTbl>();

    [InverseProperty("User")]
    public virtual ICollection<PersonCreditDetailTbl> PersonCreditDetailTbls { get; set; } = new List<PersonCreditDetailTbl>();

    [InverseProperty("UserNoNavigation")]
    public virtual ICollection<PricingTbl> PricingTbls { get; set; } = new List<PricingTbl>();

    [InverseProperty("RecevieUser")]
    public virtual ICollection<ScaduleCircuitTbl> ScaduleCircuitTblRecevieUsers { get; set; } = new List<ScaduleCircuitTbl>();

    [InverseProperty("SendUser")]
    public virtual ICollection<ScaduleCircuitTbl> ScaduleCircuitTblSendUsers { get; set; } = new List<ScaduleCircuitTbl>();

    [InverseProperty("FkUser")]
    public virtual ICollection<TaxInvoice> TaxInvoices { get; set; } = new List<TaxInvoice>();

    [InverseProperty("UserNoNavigation")]
    public virtual ICollection<TransferWareHoseTbl> TransferWareHoseTbls { get; set; } = new List<TransferWareHoseTbl>();
}
