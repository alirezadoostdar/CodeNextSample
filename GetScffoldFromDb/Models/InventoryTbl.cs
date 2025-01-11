using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class InventoryTbl
{
    public int InventorySerial { get; set; }

    public int InventoryNo { get; set; }

    public int UserNo { get; set; }

    public int Sign { get; set; }

    public int Type { get; set; }

    public string ShamsiDate { get; set; } = null!;

    public DateTime Date { get; set; }

    public string ShamsiSysDate { get; set; } = null!;

    public DateTime SysDate { get; set; }

    public string? Comment { get; set; }

    public bool IsTemp { get; set; }

    public int? FkInvoiceSerial { get; set; }

    public int? FkTransferSerial { get; set; }

    public int? FkDriversSysCode { get; set; }

    public int? FkDistributorSysCode { get; set; }

    public string? Field1 { get; set; }

    public string? Field2 { get; set; }

    public string? Field3 { get; set; }

    public string? Field4 { get; set; }

    public string? Field5 { get; set; }

    public int? FkAccountSysCode { get; set; }

    public string? CustomerName { get; set; }

    public byte FkYearId { get; set; }

    public virtual CodeMngdwntbl? FkAccountSysCodeNavigation { get; set; }

    public virtual PersonTbl? FkDistributorSysCodeNavigation { get; set; }

    public virtual PersonTbl? FkDriversSysCodeNavigation { get; set; }

    public virtual InvoiceTbl? FkInvoiceSerialNavigation { get; set; }

    public virtual TransferWareHoseTbl? FkTransferSerialNavigation { get; set; }

    public virtual FinancialYear FkYear { get; set; } = null!;

    public virtual ICollection<InventoryDetailTbl> InventoryDetailTbls { get; set; } = new List<InventoryDetailTbl>();

    public virtual User UserNoNavigation { get; set; } = null!;
}
