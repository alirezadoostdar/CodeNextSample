using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("GoodsOfStockForPrint")]
public partial class GoodsOfStockForPrint
{
    public int GoodSysCode { get; set; }
}
