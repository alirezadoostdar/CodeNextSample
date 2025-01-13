using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class MoreBarCodeTbl
{
    public int SysCode { get; set; }

    public int FkGoodSysCode { get; set; }

    public string BarCode { get; set; } = null!;
}
