using System;

public class SimpleStack
{
    private readonly object[] _items;
    private int _curentIndex = -1;
    //public SimpleStack()
    //{
    //    _items = new double[10];
    //}

    public SimpleStack() => _items = new object[10]; //experion body

    //public void Push(double item)
    //{
    //    _curentIndex++;SS
    //    _items[_curentIndex] = item;
    //}

    public int Count => _curentIndex + 1;
    public void Push(object item) => _items[++_curentIndex] = item;

    public object Pop => _items[_curentIndex--];
}