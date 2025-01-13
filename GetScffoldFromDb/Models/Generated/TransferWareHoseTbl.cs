using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class TransferWareHoseTbl
{
    public string Comment { get; set; } = null!;

    public int TransferSerialNo { get; set; }

    public string? TransferDate { get; set; }

    public int UserNo { get; set; }

    public DateTime SysDate { get; set; }

    public string? SysShamsiDate { get; set; }

    public int? TransferNo { get; set; }

    public bool Ismovaghat { get; set; }

    public byte FkYearId { get; set; }

    public virtual FinancialYear FkYear { get; set; } = null!;

    public virtual ICollection<InventoryTbl> InventoryTbls { get; set; } = new List<InventoryTbl>();

    public virtual ICollection<TransferWareHoseDetailTbl> TransferWareHoseDetailTbls { get; set; } = new List<TransferWareHoseDetailTbl>();

    public virtual User UserNoNavigation { get; set; } = null!;
}
