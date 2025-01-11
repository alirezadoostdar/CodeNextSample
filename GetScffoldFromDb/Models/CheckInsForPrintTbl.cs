using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class CheckInsForPrintTbl
{
    public int Radif { get; set; }

    public long SerialNo { get; set; }

    public string Accno { get; set; } = null!;

    public string? CheckDate { get; set; }

    public string BankName { get; set; } = null!;

    public decimal Amount { get; set; }
}
