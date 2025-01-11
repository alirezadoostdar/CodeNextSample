using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("TaxSetting")]
[Index("MeliCode", Name = "UQ__TaxSetti__59B24E73A71D4C7C", IsUnique = true)]
public partial class TaxSetting
{
    [Key]
    public int Id { get; set; }

    [Column("Title_FilaName")]
    [StringLength(150)]
    public string TitleFilaName { get; set; } = null!;

    [StringLength(20)]
    public string? MeliCode { get; set; }

    [Column("Memory_Id")]
    [StringLength(20)]
    public string MemoryId { get; set; } = null!;

    [StringLength(20)]
    public string EconomicCode { get; set; } = null!;

    [StringLength(20)]
    public string? ZipCode { get; set; }

    [StringLength(100)]
    public string? BaseUrl { get; set; }

    [Column("Publick_Key")]
    [StringLength(3000)]
    public string? PublickKey { get; set; }

    [Column("Private_Key")]
    [StringLength(3000)]
    public string PrivateKey { get; set; } = null!;

    [Column("Cetificate_Code")]
    [StringLength(4000)]
    public string? CetificateCode { get; set; }

    [InverseProperty("FkTaxSetting")]
    public virtual ICollection<TaxInvoice> TaxInvoices { get; set; } = new List<TaxInvoice>();
}
