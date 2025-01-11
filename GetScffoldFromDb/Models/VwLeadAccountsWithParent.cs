using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwLeadAccountsWithParent
{
    [Column("level3ID")]
    public int Level3Id { get; set; }

    [Column("Level2ID")]
    public int Level2Id { get; set; }

    [Column("Level1ID")]
    public int Level1Id { get; set; }

    [Column("Level0ID")]
    public int Level0Id { get; set; }

    [StringLength(250)]
    public string Level3Title { get; set; } = null!;

    [StringLength(250)]
    public string Level2Title { get; set; } = null!;

    [StringLength(250)]
    public string Level1Title { get; set; } = null!;

    [StringLength(250)]
    public string Level0Title { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string Code0 { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string Code1 { get; set; } = null!;

    [StringLength(80)]
    [Unicode(false)]
    public string Code2 { get; set; } = null!;

    [StringLength(120)]
    [Unicode(false)]
    public string Code3 { get; set; } = null!;

    [StringLength(120)]
    [Unicode(false)]
    public string Code { get; set; } = null!;
}
