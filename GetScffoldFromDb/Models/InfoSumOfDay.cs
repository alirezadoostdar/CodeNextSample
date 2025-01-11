using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class InfoSumOfDay
{
    public int Month { get; set; }

    [Column("SDay1")]
    public int Sday1 { get; set; }

    [Column("SDay2")]
    public int Sday2 { get; set; }

    [Column("GDay1")]
    public int Gday1 { get; set; }

    [Column("GDay2")]
    public int Gday2 { get; set; }
}
