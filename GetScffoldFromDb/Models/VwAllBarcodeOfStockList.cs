using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwAllBarcodeOfStockList
{
    public int GoodSyscode { get; set; }

    public string? BarCode { get; set; }
}
