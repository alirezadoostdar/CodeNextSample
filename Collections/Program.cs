// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



public interface IEnumarable
{
    IEnumerator GetEnumarator();
}
public interface IEnumerator
{
    //هر کالکشنی باید این سه متد زیر را داشته باشد
    bool MoveNext();
    object Current();
    void Reset();
}

public class ListOfInt : IEnumerator
{
    int[] _int = [2,3,4,5,6];
    int _index = -1;
    public object Current() => _int[_index];

    public bool MoveNext()
    {
        if(_index++<_int.Length-1)
            return true;
        return false;
    }

    public void Reset()
    {
        _index = -1;
    }
}