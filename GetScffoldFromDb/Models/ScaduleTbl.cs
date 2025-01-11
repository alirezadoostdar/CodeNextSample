using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class ScaduleTbl
{
    public int SysCode { get; set; }

    public string Comment { get; set; } = null!;

    public string? DateS { get; set; }

    public DateTime TimeS { get; set; }

    public int UserId { get; set; }

    public bool? Viwed { get; set; }

    public int? DocCode { get; set; }

    public string Title { get; set; } = null!;

    public bool Finished { get; set; }

    public DateTime SysDate { get; set; }

    public string ShamsiSysDate { get; set; } = null!;

    public int? FkPersonId { get; set; }

    public int? FkGoodSysCode { get; set; }

    public int ReceiveUserId { get; set; }

    public DateTime? FinishSysDate { get; set; }

    public string? FinishShamsiDate { get; set; }

    public int? FinishUserId { get; set; }

    public virtual StockTbl? FkGoodSysCodeNavigation { get; set; }

    public virtual CodeMngdwntbl? FkPerson { get; set; }

    public virtual User ReceiveUser { get; set; } = null!;
}
