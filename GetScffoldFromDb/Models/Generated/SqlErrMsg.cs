using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class SqlErrMsg
{
    public int Msgnum { get; set; }

    public int Severity { get; set; }

    public string Msgtext { get; set; } = null!;

    public string MsgtextEn { get; set; } = null!;

    public string Replace { get; set; } = null!;
}
