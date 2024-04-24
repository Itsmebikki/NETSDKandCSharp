using System;
using System.Collections.Generic;

public class Generics
{
    public void Print<T>(T x)
    {
        Console.WriteLine(x);
    }

    public void Test()
    {
        Print<string>("435234");
        Print<int>(435234);
        Print<decimal>(43523.234m);
        Print<byte>(234);

        List<int> marks= [];
        // 
        marks.Add(89);
    }
}