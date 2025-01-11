using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("ContactImagesTBL")]
public partial class ContactImagesTbl
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(100)]
    public string ImageName { get; set; } = null!;

    [Column(TypeName = "image")]
    public byte[] Images { get; set; } = null!;

    [Column("FK_TelBookID")]
    public int FkTelBookId { get; set; }

    [ForeignKey("FkTelBookId")]
    [InverseProperty("ContactImagesTbls")]
    public virtual TelBook FkTelBook { get; set; } = null!;
}
