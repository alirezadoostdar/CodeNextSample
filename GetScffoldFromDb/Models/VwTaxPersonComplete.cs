using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwTaxPersonComplete
{
    public string Title { get; set; } = null!;

    public int AccountSysCode { get; set; }

    public string? PersonKindTitle { get; set; }

    public byte? FkTaxPersonKindId { get; set; }

    public string? Tel { get; set; }

    public string? Mobile { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? ZipCode { get; set; }

    public string? SabtNo { get; set; }

    public string? MeliCode { get; set; }

    public string? EghtesadCode { get; set; }

    public string? ShenasehMeli { get; set; }

    public string? HesabNo { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }
}
