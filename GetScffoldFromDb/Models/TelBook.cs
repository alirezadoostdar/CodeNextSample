using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("TelBook")]
public partial class TelBook
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string Comment { get; set; } = null!;

    [Column("OwnerUserID")]
    public int OwnerUserId { get; set; }

    [Column("FK_IDCity")]
    public int? FkIdcity { get; set; }

    [Column("FK_IDOstan")]
    public int? FkIdostan { get; set; }

    [Column("FK_Zone")]
    public int? FkZone { get; set; }

    [StringLength(50)]
    public string? Company { get; set; }

    [Column("TelegramID")]
    [StringLength(200)]
    public string? TelegramId { get; set; }

    [StringLength(50)]
    public string? TelegramMobileNo { get; set; }

    [Column(TypeName = "decimal(18, 14)")]
    public decimal? Latitude { get; set; }

    [Column(TypeName = "decimal(18, 14)")]
    public decimal? Longitude { get; set; }

    [InverseProperty("FkTelBook")]
    public virtual ICollection<BranchTbl> BranchTbls { get; set; } = new List<BranchTbl>();

    [InverseProperty("FkTelBook")]
    public virtual ICollection<ContactImagesTbl> ContactImagesTbls { get; set; } = new List<ContactImagesTbl>();

    [ForeignKey("FkIdcity")]
    [InverseProperty("TelBooks")]
    public virtual CityTbl? FkIdcityNavigation { get; set; }

    [ForeignKey("FkIdostan")]
    [InverseProperty("TelBooks")]
    public virtual OstanTbl? FkIdostanNavigation { get; set; }

    [InverseProperty("Contact")]
    public virtual ICollection<PersonTbl> PersonTbls { get; set; } = new List<PersonTbl>();

    [InverseProperty("TelBook")]
    public virtual ICollection<TelNumber> TelNumbers { get; set; } = new List<TelNumber>();
}
