using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("InvoiceInfoPrint")]
public partial class InvoiceInfoPrint
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    public string Title { get; set; } = null!;

    [StringLength(300)]
    public string ShopName { get; set; } = null!;

    [StringLength(1000)]
    public string? ShopComment { get; set; }

    [StringLength(50)]
    public string Tel1 { get; set; } = null!;

    [StringLength(50)]
    public string Tel2 { get; set; } = null!;

    [StringLength(50)]
    public string? Mobile1 { get; set; }

    [StringLength(50)]
    public string? Mobile2 { get; set; }

    [StringLength(50)]
    public string? Address1 { get; set; }

    [StringLength(20)]
    public string? ZipCode { get; set; }

    [StringLength(50)]
    public string? EconomicCode { get; set; }

    [StringLength(50)]
    public string? IdNumberCompony { get; set; }

    [StringLength(50)]
    public string? IdNumberPerson { get; set; }

    [StringLength(500)]
    public string? AccountNumber1 { get; set; }

    [StringLength(500)]
    public string? AccountNumber2 { get; set; }

    [StringLength(500)]
    public string? Term1 { get; set; }

    [StringLength(500)]
    public string? Term2 { get; set; }

    [StringLength(500)]
    public string? Comment { get; set; }

    [StringLength(500)]
    public string? Feild1 { get; set; }

    [StringLength(500)]
    public string? Feild2 { get; set; }

    [StringLength(500)]
    public string? Feild3 { get; set; }

    [StringLength(500)]
    public string? Feild4 { get; set; }

    [StringLength(500)]
    public string? Feild5 { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Logo { get; set; }

    [InverseProperty("PrintInfo")]
    public virtual ICollection<DefaultPrintInfoLay> DefaultPrintInfoLays { get; set; } = new List<DefaultPrintInfoLay>();
}
