using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwContactIdContactSumary
{
    public string Address { get; set; } = null!;

    public int Id { get; set; }

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

    public int? FkIdcity { get; set; }

    public int? FkIdostan { get; set; }

    public int? FkZone { get; set; }

    public string? Name { get; set; }

    public string? Family { get; set; }

    public string? FatherName { get; set; }
}
