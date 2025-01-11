using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwVisitorDriverMovaze
{
    public string? بازاریاب2 { get; set; }

    [Column("تلفن بازاریاب 2")]
    [StringLength(50)]
    public string? تلفنبازاریاب2 { get; set; }

    [Column("موبایل بازاریاب 2")]
    [StringLength(50)]
    public string? موبایلبازاریاب2 { get; set; }

    [Column("نام راننده")]
    public string? نامراننده { get; set; }

    [Column("تلفن راننده")]
    [StringLength(50)]
    public string? تلفنراننده { get; set; }

    [Column("موبایل راننده")]
    [StringLength(50)]
    public string? موبایلراننده { get; set; }

    [Column("نام موزع")]
    public string? نامموزع { get; set; }

    [Column("تلفن موزع")]
    [StringLength(50)]
    public string? تلفنموزع { get; set; }

    [Column("موبایل موزع")]
    [StringLength(50)]
    public string? موبایلموزع { get; set; }

    [Column("نحوه تسویه")]
    [StringLength(100)]
    public string? نحوهتسویه { get; set; }

    public int InvoiceSerialNo { get; set; }
}
