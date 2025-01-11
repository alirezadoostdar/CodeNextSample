using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class DeletedCodeMngdwntbl
{
    public int FkAccountSysCode0 { get; set; }

    public int AccountSysCode { get; set; }

    public string Title { get; set; } = null!;

    public decimal CreditLimit { get; set; }

    public int SecurLevel { get; set; }

    public bool? BedehkarOnly { get; set; }

    public bool DeleteOnServer { get; set; }
}
