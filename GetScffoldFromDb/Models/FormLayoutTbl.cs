using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class FormLayoutTbl
{
    public int Id { get; set; }

    public string FormName { get; set; } = null!;

    public byte[] Xmldata { get; set; } = null!;

    public int FkUid { get; set; }

    public byte LanguageId { get; set; }
}
