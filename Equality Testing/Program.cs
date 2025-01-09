
Point2D p1 = new Point2D { X = 10, Y = 20 };
Point2D p2 = new Point2D { X = 10, Y = 20 };

Console.WriteLine($"{p1.Equals(p2)}");
Console.WriteLine($"{p1 == p2}");
Console.WriteLine($"{p1 != p2}");


public class Point2D : IEquatable<Point2D>
{
    public int X { get; set; }
    public int Y { get; set; }



    public override bool Equals(object? obj) => Equals(obj as Point2D);
    public bool Equals(Point2D? p) => p != null && (X == p.X && Y == p.Y);
    public override int GetHashCode() => (X, Y).GetHashCode();

    public static bool operator == (Point2D? p1, Point2D? p2)
    {
        if (p1 is null)
        {
            if (p2 is null)
            {
                return true;
            }
            return false;
        }
        return p1.Equals(p2);
    }

    public static bool operator != (Point2D? p1, Point2D? p2) => !(p1 == p2);
}