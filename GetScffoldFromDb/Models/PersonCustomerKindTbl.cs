using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("PersonCustomerKindTBL")]
public partial class PersonCustomerKindTbl
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(200)]
    public string? Title { get; set; }

    [InverseProperty("FkPersonCutomerKindNavigation")]
    public virtual ICollection<PersonTbl> PersonTbls { get; set; } = new List<PersonTbl>();
}
