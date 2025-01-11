using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwInvoiceTasviehComplete
{
    public int DocCode { get; set; }

    public int InvoiceSerialNo { get; set; }

    [Column(TypeName = "money")]
    public decimal? Amount { get; set; }

    [Column("Fk_AccountSyscode")]
    public int FkAccountSyscode { get; set; }

    public string Title { get; set; } = null!;

    public string UpTitle { get; set; } = null!;

    [Column("AmmountIN", TypeName = "money")]
    public decimal AmmountIn { get; set; }

    [Column("AmmountOUT", TypeName = "money")]
    public decimal AmmountOut { get; set; }

    public int AccountSysCode { get; set; }

    public int AccountSysCode0 { get; set; }

    public int Syscode { get; set; }
}
