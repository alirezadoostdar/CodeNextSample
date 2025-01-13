using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class WarehouseCounting
{
    public int Id { get; set; }

    public int Code { get; set; }

    public int? FkDocSysCodeIn { get; set; }

    public int? FkDocSysCodeOut { get; set; }

    public string? Comment { get; set; }

    public bool IsTemp { get; set; }

    public string ShamsiDate { get; set; } = null!;

    public DateTime MiladiDate { get; set; }

    public string RegShamsiDate { get; set; } = null!;

    public DateTime RegMiladiDate { get; set; }

    public int RegUserId { get; set; }

    public string? EditShamsiDate { get; set; }

    public DateTime? EditMiladiDate { get; set; }

    public int? EditUserId { get; set; }

    public int? LastInvoiceSerial { get; set; }

    public int? LastTransferSerial { get; set; }

    public int? LastInventorySerial { get; set; }

    public byte FkYearId { get; set; }

    public int? FkProjectId { get; set; }

    public virtual ProjectTbl? FkProject { get; set; }

    public virtual FinancialYear FkYear { get; set; } = null!;

    public virtual ICollection<WarehouseCountingDetail> WarehouseCountingDetails { get; set; } = new List<WarehouseCountingDetail>();
}
