using System;

public class SimpleStack<TItem>
{
    private readonly TItem[] _items;
    private int _curentIndex = -1;
    //public SimpleStack()
    //{
    //    _items = new double[10];
    //}

    public SimpleStack() => _items = new TItem[10]; //experion body

    //public void Push(double item)
    //{
    //    _curentIndex++;SS
    //    _items[_curentIndex] = item;
    //}

    public int Count => _curentIndex + 1;
    public void Push(TItem item) => _items[++_curentIndex] = item;

    public TItem Pop => _items[_curentIndex--];
}