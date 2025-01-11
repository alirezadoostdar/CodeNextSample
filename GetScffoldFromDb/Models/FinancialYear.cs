using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("FinancialYear")]
public partial class FinancialYear
{
    [Key]
    public byte Id { get; set; }

    [StringLength(100)]
    public string Title { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string StartDateShamsi { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StartDateMiladi { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string EndDateShamsi { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime EndDateMiladi { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RegisterDate { get; set; }

    public bool Active { get; set; }

    [InverseProperty("FkYear")]
    public virtual ICollection<DocTbl> DocTbls { get; set; } = new List<DocTbl>();

    [InverseProperty("FkYear")]
    public virtual ICollection<InventoryTbl> InventoryTbls { get; set; } = new List<InventoryTbl>();

    [InverseProperty("FkYear")]
    public virtual ICollection<InvoiceTbl> InvoiceTbls { get; set; } = new List<InvoiceTbl>();

    [InverseProperty("FkYear")]
    public virtual ICollection<TransferWareHoseTbl> TransferWareHoseTbls { get; set; } = new List<TransferWareHoseTbl>();

    [InverseProperty("FkYear")]
    public virtual ICollection<WarehouseCounting> WarehouseCountings { get; set; } = new List<WarehouseCounting>();
}
