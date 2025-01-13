using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class TelNumber
{
    public int? TelBookId { get; set; }

    public string? TelNo { get; set; }

    public byte? TelNoType { get; set; }

    public int SysCode { get; set; }

    public string? Title { get; set; }

    public virtual TelBook? TelBook { get; set; }
}
