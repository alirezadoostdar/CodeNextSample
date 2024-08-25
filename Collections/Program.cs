ListOfInt mylist = new ListOfInt();
var enumerator = mylist.GetEnumarator();
while (enumerator.MoveNext())
{
    var value = enumerator.Current();
    Console.WriteLine(value);
}


List<int> list = new List<int>();

public interface IEnumarable
{
    IEnumerator GetEnumarator();
}

public interface IEnumerable<T> : IEnumarable
{
    IEnumerable<T> GetEnumerator();
}
public interface IEnumerator
{
    //هر کالکشنی باید این سه متد زیر را داشته باشد
    bool MoveNext();
    object Current();
    void Reset();
}

public interface IEnumerator<T> : IEnumerator, IDisposable
{
    T Current();
}
public class ListOfInt : IEnumarable
{
    int[] _int = [2, 3, 4, 5, 6];

    public IEnumerator GetEnumarator()
    {
        return new SingleEnumerator(_int);
    }
}


public class SingleEnumerator : IEnumerator
{
    int[] _int;
    int _index = -1;
    public SingleEnumerator(int[] intArray)
    {
        _int = intArray;
    }
    public object Current() => _int[_index];

    public bool MoveNext()
    {
        if (_index++ < _int.Length - 1)
            return true;
        return false;
    }

    public void Reset()
    {
        _index = -1;
    }
}