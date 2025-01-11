using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class InfoParamDescribtion
{
    public string? ParamName { get; set; }

    public string? ParamDescribtion { get; set; }

    public string? EditorType { get; set; }

    public string? ParamValue { get; set; }
}
