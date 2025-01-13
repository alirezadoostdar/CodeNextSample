using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class GpstrackingTbl
{
    public int FkAccountSysCode { get; set; }

    public DateOnly TrackingDate { get; set; }

    public byte TrackingHour { get; set; }

    public byte TrackingMinute { get; set; }

    public string Lat { get; set; } = null!;

    public string Long { get; set; } = null!;

    public long TrackingId { get; set; }

    public string ShamsiDate { get; set; } = null!;

    public DateTime Dt { get; set; }

    public virtual CodeMngdwntbl FkAccountSysCodeNavigation { get; set; } = null!;
}
