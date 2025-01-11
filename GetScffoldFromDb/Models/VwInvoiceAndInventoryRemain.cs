using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwInvoiceAndInventoryRemain
{
    public int GoodSysCode { get; set; }

    public double? Remain { get; set; }

    public int Color { get; set; }

    public int Size { get; set; }

    public string SerialNo { get; set; } = null!;

    public int WareHouse { get; set; }

    public string DateExpire { get; set; } = null!;

    public int? InvoiceSerialNo { get; set; }

    public int Sign { get; set; }
}
