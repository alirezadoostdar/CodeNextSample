using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class FinancialYear
{
    public byte Id { get; set; }

    public string Title { get; set; } = null!;

    public string StartDateShamsi { get; set; } = null!;

    public DateTime StartDateMiladi { get; set; }

    public string EndDateShamsi { get; set; } = null!;

    public DateTime EndDateMiladi { get; set; }

    public DateTime RegisterDate { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<DocTbl> DocTbls { get; set; } = new List<DocTbl>();

    public virtual ICollection<InventoryTbl> InventoryTbls { get; set; } = new List<InventoryTbl>();

    public virtual ICollection<InvoiceTbl> InvoiceTbls { get; set; } = new List<InvoiceTbl>();

    public virtual ICollection<TransferWareHoseTbl> TransferWareHoseTbls { get; set; } = new List<TransferWareHoseTbl>();

    public virtual ICollection<WarehouseCounting> WarehouseCountings { get; set; } = new List<WarehouseCounting>();
}
