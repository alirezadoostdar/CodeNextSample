using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwInventoryGoodSimpleRemain
{
    public int GoodSysCode { get; set; }

    public double? Remain { get; set; }
}
