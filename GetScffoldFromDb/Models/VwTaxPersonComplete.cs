using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwTaxPersonComplete
{
    public string Title { get; set; } = null!;

    public int AccountSysCode { get; set; }

    [StringLength(50)]
    public string? PersonKindTitle { get; set; }

    [Column("Fk_TaxPersonKindId")]
    public byte? FkTaxPersonKindId { get; set; }

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

    [StringLength(200)]
    public string? City { get; set; }

    [StringLength(200)]
    public string? State { get; set; }
}
