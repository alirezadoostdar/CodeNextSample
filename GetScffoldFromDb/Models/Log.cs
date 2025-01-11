using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class Log
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? RequestIp { get; set; }

    public bool IsSuccess { get; set; }

    public DateTime LogDate { get; set; }

    public string? ClassName { get; set; }

    public string? MethodName { get; set; }

    public string? ContorollerName { get; set; }

    public string? ActionName { get; set; }

    public int? StatusCode { get; set; }

    public string? ResultMessage { get; set; }

    public string? ExceptionMessage { get; set; }

    public string? ExceptionSource { get; set; }

    public string? InputModel { get; set; }

    public string? OutputModel { get; set; }
}
