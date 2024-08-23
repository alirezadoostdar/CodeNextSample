namespace GetMehrData;

public class AppSettings
{
    public required ConnectionString ConnectionStrings { get; set; }
}

public class ConnectionString
{
    public required string MehrAccountingConnection { get; set; }
}
