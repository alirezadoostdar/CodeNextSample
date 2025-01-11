using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

public partial class Log
{
    [Key]
    public int Id { get; set; }

    public int UserId { get; set; }

    [StringLength(200)]
    public string? UserName { get; set; }

    [StringLength(20)]
    public string? RequestIp { get; set; }

    public bool IsSuccess { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LogDate { get; set; }

    [StringLength(100)]
    public string? ClassName { get; set; }

    [StringLength(100)]
    public string? MethodName { get; set; }

    [StringLength(200)]
    public string? ContorollerName { get; set; }

    [StringLength(200)]
    public string? ActionName { get; set; }

    public int? StatusCode { get; set; }

    [StringLength(300)]
    public string? ResultMessage { get; set; }

    [Column(TypeName = "ntext")]
    public string? ExceptionMessage { get; set; }

    [Column(TypeName = "ntext")]
    public string? ExceptionSource { get; set; }

    [Column(TypeName = "ntext")]
    public string? InputModel { get; set; }

    [Column(TypeName = "ntext")]
    public string? OutputModel { get; set; }
}
