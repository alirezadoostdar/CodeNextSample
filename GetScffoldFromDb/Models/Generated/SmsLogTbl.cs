using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class SmsLogTbl
{
    public int SysCode { get; set; }

    public int? AccountSysCode { get; set; }

    public string? Mobile { get; set; }

    public DateTime? Date { get; set; }

    public string? ShamsiDate { get; set; }

    public string? Message { get; set; }

    public bool? IsSuccessfull { get; set; }

    public string? Msg { get; set; }

    public string? PanelId { get; set; }

    public string? BatchKey { get; set; }
}
