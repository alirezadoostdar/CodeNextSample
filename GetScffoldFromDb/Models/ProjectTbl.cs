using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("ProjectTBL")]
public partial class ProjectTbl
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(500)]
    public string Title { get; set; } = null!;

    public bool Active { get; set; }

    [InverseProperty("FkProject")]
    public virtual ICollection<DocTbl> DocTbls { get; set; } = new List<DocTbl>();

    [InverseProperty("FkProject")]
    public virtual ICollection<InvoiceTbl> InvoiceTbls { get; set; } = new List<InvoiceTbl>();

    [InverseProperty("FkProject")]
    public virtual ICollection<WarehouseCounting> WarehouseCountings { get; set; } = new List<WarehouseCounting>();
}
