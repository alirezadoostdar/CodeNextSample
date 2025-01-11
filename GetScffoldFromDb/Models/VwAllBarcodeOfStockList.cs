using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwAllBarcodeOfStockList
{
    public int GoodSyscode { get; set; }

    [StringLength(100)]
    public string? BarCode { get; set; }
}
