using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class DefaultPrintInfoLay
{
    public int Id { get; set; }

    public int FkPrintLayoutId { get; set; }

    public int UserId { get; set; }

    public int PrintInfoId { get; set; }

    public virtual PrintLayout FkPrintLayout { get; set; } = null!;

    public virtual InvoiceInfoPrint PrintInfo { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
