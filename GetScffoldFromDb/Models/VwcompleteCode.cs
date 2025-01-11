using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwcompleteCode
{
    public int AccountSysCode { get; set; }

    public string Title { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal CreditLimit { get; set; }

    public byte SecurLevel { get; set; }

    public int Code0 { get; set; }

    public string Title0 { get; set; } = null!;

    public byte Kind { get; set; }
}
