using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class ProjectTbl
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public bool Active { get; set; }

    public virtual ICollection<DocTbl> DocTbls { get; set; } = new List<DocTbl>();

    public virtual ICollection<InvoiceTbl> InvoiceTbls { get; set; } = new List<InvoiceTbl>();

    public virtual ICollection<WarehouseCounting> WarehouseCountings { get; set; } = new List<WarehouseCounting>();
}
