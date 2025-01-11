using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class DataBaseSettingTbl
{
    public string KeyName { get; set; } = null!;

    public string? KeyValue { get; set; }

    public int UserId { get; set; }

    public int Syscode { get; set; }
}
