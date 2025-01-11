using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("InventoryTBL")]
public partial class InventoryTbl
{
    [Key]
    public int InventorySerial { get; set; }

    public int InventoryNo { get; set; }

    public int UserNo { get; set; }

    public int Sign { get; set; }

    public int Type { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ShamsiDate { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ShamsiSysDate { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime SysDate { get; set; }

    public string? Comment { get; set; }

    public bool IsTemp { get; set; }

    [Column("Fk_InvoiceSerial")]
    public int? FkInvoiceSerial { get; set; }

    [Column("Fk_TransferSerial")]
    public int? FkTransferSerial { get; set; }

    [Column("Fk_DriversSysCode")]
    public int? FkDriversSysCode { get; set; }

    [Column("Fk_DistributorSysCode")]
    public int? FkDistributorSysCode { get; set; }

    [StringLength(1000)]
    public string? Field1 { get; set; }

    [StringLength(1000)]
    public string? Field2 { get; set; }

    [StringLength(1000)]
    public string? Field3 { get; set; }

    [StringLength(1000)]
    public string? Field4 { get; set; }

    [StringLength(1000)]
    public string? Field5 { get; set; }

    [Column("FK_AccountSysCode")]
    public int? FkAccountSysCode { get; set; }

    [StringLength(200)]
    public string? CustomerName { get; set; }

    [Column("Fk_YearId")]
    public byte FkYearId { get; set; }

    [ForeignKey("FkAccountSysCode")]
    [InverseProperty("InventoryTbls")]
    public virtual CodeMngdwntbl? FkAccountSysCodeNavigation { get; set; }

    [ForeignKey("FkDistributorSysCode")]
    [InverseProperty("InventoryTblFkDistributorSysCodeNavigations")]
    public virtual PersonTbl? FkDistributorSysCodeNavigation { get; set; }

    [ForeignKey("FkDriversSysCode")]
    [InverseProperty("InventoryTblFkDriversSysCodeNavigations")]
    public virtual PersonTbl? FkDriversSysCodeNavigation { get; set; }

    [ForeignKey("FkInvoiceSerial")]
    [InverseProperty("InventoryTbls")]
    public virtual InvoiceTbl? FkInvoiceSerialNavigation { get; set; }

    [ForeignKey("FkTransferSerial")]
    [InverseProperty("InventoryTbls")]
    public virtual TransferWareHoseTbl? FkTransferSerialNavigation { get; set; }

    [ForeignKey("FkYearId")]
    [InverseProperty("InventoryTbls")]
    public virtual FinancialYear FkYear { get; set; } = null!;

    [InverseProperty("FkInventorySysCodeNavigation")]
    public virtual ICollection<InventoryDetailTbl> InventoryDetailTbls { get; set; } = new List<InventoryDetailTbl>();

    [ForeignKey("UserNo")]
    [InverseProperty("InventoryTbls")]
    public virtual User UserNoNavigation { get; set; } = null!;
}
