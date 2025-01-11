using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwgoodDetailRemainForPropertyInvoice
{
    public int GoodSysCode { get; set; }

    public int Color { get; set; }

    public int Size { get; set; }

    public string SerialNo { get; set; } = null!;

    public int WareHouse { get; set; }

    public string DateExpire { get; set; } = null!;
}
