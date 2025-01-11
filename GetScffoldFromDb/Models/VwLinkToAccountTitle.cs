using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwLinkToAccountTitle
{
    public int? LinkToAccount { get; set; }

    public string? LinkToTitle { get; set; }

    public int LinkTo { get; set; }

    public int LinkFrom { get; set; }

    [Column("FK_AccountSysCode0")]
    public int? FkAccountSysCode0 { get; set; }
}
