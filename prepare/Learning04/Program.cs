using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assingment a1 = new Assingment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.getSummary());

        mathAssingment a2 = new mathAssingment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.getSummary());
        Console.WriteLine(a2.getHomework());

        writingAssingment a3 = new writingAssingment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.getSummary());
        Console.WriteLine(a3.getWritingInfo());
    }
}