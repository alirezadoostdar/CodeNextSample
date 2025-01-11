using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwContactIdContactSumary
{
    public string Address { get; set; } = null!;

    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Tel { get; set; }

    [StringLength(50)]
    public string? Mobile { get; set; }

    [Column("fax")]
    [StringLength(50)]
    public string? Fax { get; set; }

    [Column("email")]
    [StringLength(50)]
    public string? Email { get; set; }

    [Column("ZipCOde")]
    [StringLength(50)]
    public string? ZipCode { get; set; }

    [StringLength(50)]
    public string? SabtNo { get; set; }

    [StringLength(50)]
    public string? MeliCode { get; set; }

    [StringLength(50)]
    public string? EghtesadCode { get; set; }

    [StringLength(50)]
    public string? ShenasehMeli { get; set; }

    [StringLength(50)]
    public string? HesabNo { get; set; }

    [Column("FK_IDCity")]
    public int? FkIdcity { get; set; }

    [Column("FK_IDOstan")]
    public int? FkIdostan { get; set; }

    [Column("FK_Zone")]
    public int? FkZone { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? Family { get; set; }

    [StringLength(50)]
    public string? FatherName { get; set; }
}
