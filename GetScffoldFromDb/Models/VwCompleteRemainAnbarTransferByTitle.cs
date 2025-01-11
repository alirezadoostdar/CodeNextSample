using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwCompleteRemainAnbarTransferByTitle
{
    public double? Remain { get; set; }

    [StringLength(1000)]
    public string? WareHouseName { get; set; }

    [StringLength(1000)]
    public string? ColorName { get; set; }

    [StringLength(1000)]
    public string? SizeName { get; set; }

    [StringLength(100)]
    public string? SerialNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DateExpire { get; set; }

    public int? Color { get; set; }

    public int? Size { get; set; }

    public int? WareHouse { get; set; }

    public int GoodSysCode { get; set; }
}
