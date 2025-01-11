using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwgoodDetailRemainForPropertyInvoice
{
    public int GoodSysCode { get; set; }

    public int Color { get; set; }

    public int Size { get; set; }

    [StringLength(100)]
    public string SerialNo { get; set; } = null!;

    public int WareHouse { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DateExpire { get; set; } = null!;
}
