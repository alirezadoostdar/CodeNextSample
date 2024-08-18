// See https://aka.ms/new-console-template for more information
using ErrorOr;

ErrorOr<float> Divide(float a, float b)
{
    if (b is 0)
    {
        return Error.Unexpected();
    }
    return a / b;
}

var result = Divide(10, 2);
if (result.IsError)
{
    Console.WriteLine(result.IsError);
}
else
{
    Console.WriteLine(result.Value);
}
