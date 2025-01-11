using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwLastInvoiceOfPerson
{
    [Column("FK_AccountSysCode")]
    public int? FkAccountSysCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastInvoiceDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastInvoiceMiladiDate { get; set; }

    [Column("lastDay")]
    public int? LastDay { get; set; }

    public int? VisitorSyscode { get; set; }
}
