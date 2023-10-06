using System;
using System.Linq;

class Program
{
    static void Main()
    {
        bool boolVariable = true;
        int intVariable = 5;
        float floatVariable = 3.14f;
        string stringVariable = "Hello World!,";

        boolVariable = true;
        intVariable *= 10;
        floatVariable *= 10;
        stringVariable = string.Concat(Enumerable.Repeat(stringVariable, 10));

        Console.WriteLine("boolVariable: " + boolVariable);
        Console.WriteLine("intVariable: " + intVariable);
        Console.WriteLine("floatVariable: " + floatVariable);
        Console.WriteLine("stringVariable: " + stringVariable);
    }
}