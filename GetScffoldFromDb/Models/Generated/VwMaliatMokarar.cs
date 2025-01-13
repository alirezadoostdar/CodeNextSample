using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VwMaliatMokarar
{
    public string InvoiceDate { get; set; } = null!;

    public int Type { get; set; }

    public int? Kind { get; set; }

    public string? Name { get; set; }

    public int GoodSysCode { get; set; }

    public string Title { get; set; } = null!;

    public double? Fee { get; set; }

    public double? Maliat { get; set; }

    public double? Avarez { get; set; }

    public string? Tel { get; set; }

    public string? ZipCode { get; set; }

    public string? MeliCode { get; set; }

    public string? EghtesadCode { get; set; }

    public string? ShenasehMeli { get; set; }

    public int? FkIdcity { get; set; }

    public int? FkIdostan { get; set; }

    public string? Address { get; set; }

    public bool? OutSidePerson { get; set; }
}
