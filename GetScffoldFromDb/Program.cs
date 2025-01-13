//Scaffolding from database
//Scaffold-DbContext "Data Source=DESKTOP-NPREDR7\sql2019;Initial Catalog=mehr2180;User ID=sa;Password=bastan.net.sqlserver;MultipleActiveResultSets=true;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.Sqlserver -ContextDir Data -OutputDir Models
//Scaffold-DbContext "Data Source=DESKTOP-NPREDR7\sql2019;Initial Catalog=mehr2180;User ID=sa;Password=bastan.net.sqlserver;MultipleActiveResultSets=true;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.Sqlserver -ContextDir Data -OutputDir Models -DataAnnotation
//Scaffold-DbContext "Data Source=DESKTOP-NPREDR7\sql2019;Initial Catalog=mehr2180;User ID=sa;Password=bastan.net.sqlserver;MultipleActiveResultSets=true;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.Sqlserver -ContextDir Data -OutputDir Models/Generated -ContextNamespace PizzaShop.Data -Namespace PizzaShop.Models
public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello world");
    }
}