using System;

public class SimpleStack
{
    private readonly double[] _items;
    private int _curentIndex = -1;
    //public SimpleStack()
    //{
    //    _items = new double[10];
    //}

    public SimpleStack() => _items = new double[10]; //experion body

    //public void Push(double item)
    //{
    //    _curentIndex++;SS
    //    _items[_curentIndex] = item;
    //}

    public int Count => _curentIndex + 1;
    public void Push(double item) => _items[++_curentIndex] = item;

    public double Pop => _items[_curentIndex--];
}