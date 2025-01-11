using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwCompleteVisit
{
    public int Id { get; set; }

    public int AccountSysCode { get; set; }

    public int VisitorSysCode { get; set; }

    public int? InvoiceSerialNo { get; set; }

    public string ShamsiDate { get; set; } = null!;

    public DateTime MiladiDate { get; set; }

    public string? Comment { get; set; }

    public bool StatusId { get; set; }

    public string Long { get; set; } = null!;

    public string Lat { get; set; } = null!;

    public string? CategoryTitle { get; set; }

    public byte? CategoryId { get; set; }

    public string? VisitorName { get; set; }

    public string? PersonName { get; set; }

    public string? SatusTitle { get; set; }

    public decimal? TotalAmount { get; set; }
}
