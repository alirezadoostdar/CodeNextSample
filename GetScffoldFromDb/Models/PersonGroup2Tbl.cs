using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("PersonGroup2Tbl")]
public partial class PersonGroup2Tbl
{
    [Key]
    public int GroupId { get; set; }

    [StringLength(100)]
    public string GroupName { get; set; } = null!;

    [InverseProperty("GroupId2Navigation")]
    public virtual ICollection<PersonTbl> PersonTbls { get; set; } = new List<PersonTbl>();
}
