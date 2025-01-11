using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwLeadAccount
{
    public int AccountId { get; set; }

    public int? ParentAccountRef { get; set; }

    public int Type { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [StringLength(250)]
    public string Title { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool Lock { get; set; }

    [Column(TypeName = "money")]
    public decimal? Balance { get; set; }

    public int SecurLevel { get; set; }

    [Column("Has_MNGDWN")]
    public bool HasMngdwn { get; set; }

    [StringLength(50)]
    public string? TypeTitle { get; set; }

    [Column("Fk_AccoutnSysCode")]
    public int? FkAccoutnSysCode { get; set; }

    [Column("Fk_AccoutnSysCode0")]
    public int? FkAccoutnSysCode0 { get; set; }

    [StringLength(1000)]
    public string? SecurLevelTitle { get; set; }

    public bool IsTemp { get; set; }
}
