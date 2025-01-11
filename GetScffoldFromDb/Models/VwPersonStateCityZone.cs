using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwPersonStateCityZone
{
    public string? Title { get; set; }

    [Column("FK_IDCity")]
    public int? FkIdcity { get; set; }

    [Column("FK_IDOstan")]
    public int? FkIdostan { get; set; }

    [Column("FK_Zone")]
    public int? FkZone { get; set; }

    [StringLength(1000)]
    public string? Zone { get; set; }

    [StringLength(200)]
    public string? State { get; set; }

    [StringLength(200)]
    public string? City { get; set; }

    public int? AccountSysCode { get; set; }
}
