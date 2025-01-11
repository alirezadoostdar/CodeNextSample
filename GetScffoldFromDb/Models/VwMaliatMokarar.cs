using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwMaliatMokarar
{
    [StringLength(8)]
    [Unicode(false)]
    public string InvoiceDate { get; set; } = null!;

    public int Type { get; set; }

    public int? Kind { get; set; }

    public string? Name { get; set; }

    public int GoodSysCode { get; set; }

    [StringLength(1000)]
    public string Title { get; set; } = null!;

    public double? Fee { get; set; }

    [Column("maliat")]
    public double? Maliat { get; set; }

    public double? Avarez { get; set; }

    [StringLength(50)]
    public string? Tel { get; set; }

    [Column("ZipCOde")]
    [StringLength(50)]
    public string? ZipCode { get; set; }

    [StringLength(50)]
    public string? MeliCode { get; set; }

    [StringLength(50)]
    public string? EghtesadCode { get; set; }

    [StringLength(50)]
    public string? ShenasehMeli { get; set; }

    [Column("FK_IDCity")]
    public int? FkIdcity { get; set; }

    [Column("FK_IDOstan")]
    public int? FkIdostan { get; set; }

    public string? Address { get; set; }

    public bool? OutSidePerson { get; set; }
}
