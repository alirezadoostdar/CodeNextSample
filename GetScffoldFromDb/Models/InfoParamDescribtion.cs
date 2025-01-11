using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("InfoParamDescribtion")]
public partial class InfoParamDescribtion
{
    [StringLength(100)]
    public string? ParamName { get; set; }

    [StringLength(1000)]
    public string? ParamDescribtion { get; set; }

    [StringLength(100)]
    public string? EditorType { get; set; }

    [StringLength(100)]
    public string? ParamValue { get; set; }
}
