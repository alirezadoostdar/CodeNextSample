using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("PersonCommercialTBL")]
public partial class PersonCommercialTbl
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(200)]
    public string? Title { get; set; }

    public int? Color { get; set; }

    [StringLength(15)]
    public string? HexaColor { get; set; }

    [InverseProperty("FkPersonCommercialNavigation")]
    public virtual ICollection<PersonTbl> PersonTbls { get; set; } = new List<PersonTbl>();
}
