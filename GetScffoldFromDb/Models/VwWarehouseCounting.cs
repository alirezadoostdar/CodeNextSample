using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwWarehouseCounting
{
    public int Id { get; set; }

    public double? DeficitAmount { get; set; }

    public double? AdditionalAmount { get; set; }

    public double? TotalAmount { get; set; }

    public double? DeficitQty { get; set; }

    public double? AdditionalQty { get; set; }

    public double? TotalQty { get; set; }

    public int? RowsQty { get; set; }

    public int Code { get; set; }

    public int? FkDocSysCodeIn { get; set; }

    public int? FkDocSysCodeOut { get; set; }

    public string? Comment { get; set; }

    public bool IsTemp { get; set; }

    public string ShamsiDate { get; set; } = null!;

    public DateTime MiladiDate { get; set; }

    public string RegShamsiDate { get; set; } = null!;

    public DateTime RegMiladiDate { get; set; }

    public int RegUserId { get; set; }

    public string? EditShamsiDate { get; set; }

    public DateTime? EditMiladiDate { get; set; }

    public int? EditUserId { get; set; }

    public int? LastTransferSerial { get; set; }

    public int? LastInvoiceSerial { get; set; }

    public int? LastInventorySerial { get; set; }

    public string? RegUname { get; set; }

    public string? EditUname { get; set; }
}
