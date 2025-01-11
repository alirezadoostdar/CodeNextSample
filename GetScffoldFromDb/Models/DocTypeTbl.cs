using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("DocTypeTBL")]
public partial class DocTypeTbl
{
    [Key]
    [Column("ID")]
    public byte Id { get; set; }

    [StringLength(100)]
    public string Title { get; set; } = null!;

    [InverseProperty("FkType")]
    public virtual ICollection<DocTbl> DocTbls { get; set; } = new List<DocTbl>();
}
