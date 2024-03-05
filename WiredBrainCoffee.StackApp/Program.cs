using System;

public class Program
{
    public static void Main(string[] args)
    {
        StackDoubles();
        StackStrings();

        Console.ReadLine();
    }

    private static void StackStrings()
    {
        var stack = new SimpleStack<string>();
        stack.Push("Weird Coffe");
        stack.Push("Sweets"); 
    }

    private static void StackDoubles()
    {
        var stack = new SimpleStack<double>();
        stack.Push(1.2);
        stack.Push(2.2);
        stack.Push(3.2);
        //stack.Push(true); //not type safe anymore; will throw an error
        Console.WriteLine(stack.Count);
        double sum = 0;

        while (stack.Count > 0)
        {
            double item = (double)stack.Pop;
            Console.WriteLine($"Item: {item}");
            sum += item;
        }

        Console.WriteLine("Sum:" + sum);
    }
}
