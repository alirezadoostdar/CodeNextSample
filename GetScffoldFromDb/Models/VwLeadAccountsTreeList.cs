using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwLeadAccountsTreeList
{
    public int AccountId { get; set; }

    public int? ParentAccountRef { get; set; }

    [StringLength(373)]
    public string Title { get; set; } = null!;

    [StringLength(120)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    public int Type { get; set; }

    public int SecurLevel { get; set; }

    public bool IsActive { get; set; }

    public bool Lock { get; set; }

    [Column("Fk_AccoutnSysCode")]
    public int? FkAccoutnSysCode { get; set; }

    [Column("Fk_AccoutnSysCode0")]
    public int? FkAccoutnSysCode0 { get; set; }

    [Column("Has_MNGDWN")]
    public bool HasMngdwn { get; set; }

    [Column(TypeName = "money")]
    public decimal? Balance { get; set; }
}
