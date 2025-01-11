using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class ChangeInventoryTbl
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

    public int? OnChangeUserId { get; set; }

    public DateTime? OnChangeSysDate { get; set; }

    public bool? IsUpDated { get; set; }

    public string? OnChangeSysShamsiDate { get; set; }
}
