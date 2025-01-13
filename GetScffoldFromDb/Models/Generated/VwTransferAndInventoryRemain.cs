using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VwTransferAndInventoryRemain
{
    public int GoodSysCode { get; set; }

    public double? Remain { get; set; }

    public int Color { get; set; }

    public int Size { get; set; }

    public string SerialNo { get; set; } = null!;

    public int WareHouse { get; set; }

    public string DateExpire { get; set; } = null!;

    public int? TransferSerialNo { get; set; }

    public int Sign { get; set; }
}
