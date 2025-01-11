using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwCompleteVisit
{
    [Column("ID")]
    public int Id { get; set; }

    public int AccountSysCode { get; set; }

    public int VisitorSysCode { get; set; }

    public int? InvoiceSerialNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ShamsiDate { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime MiladiDate { get; set; }

    [StringLength(500)]
    public string? Comment { get; set; }

    [Column("StatusID")]
    public bool StatusId { get; set; }

    [StringLength(50)]
    public string Long { get; set; } = null!;

    [StringLength(50)]
    public string Lat { get; set; } = null!;

    [StringLength(200)]
    public string? CategoryTitle { get; set; }

    public byte? CategoryId { get; set; }

    public string? VisitorName { get; set; }

    public string? PersonName { get; set; }

    [StringLength(200)]
    public string? SatusTitle { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalAmount { get; set; }
}
