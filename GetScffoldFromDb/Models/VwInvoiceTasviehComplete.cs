using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwInvoiceTasviehComplete
{
    public int DocCode { get; set; }

    public int InvoiceSerialNo { get; set; }

    public decimal? Amount { get; set; }

    public int FkAccountSyscode { get; set; }

    public string Title { get; set; } = null!;

    public string UpTitle { get; set; } = null!;

    public decimal AmmountIn { get; set; }

    public decimal AmmountOut { get; set; }

    public int AccountSysCode { get; set; }

    public int AccountSysCode0 { get; set; }

    public int Syscode { get; set; }
}
