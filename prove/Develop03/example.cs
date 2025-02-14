using System;
using System.Collections.Generic;

public class ExampleClass
{
    // Step 1: Declare the private string
    private string privateString = "apple,banana,cherry";

    // Step 2: Create a public property that returns a list
    public List<string> PublicList
    {
        get
        {
            // Step 3: Convert the string to a list
            return new List<string>(privateString.Split(','));
        }
    }
}

public class Program2
{
    public static void Main()
    {
        ExampleClass example = new ExampleClass();
        List<string> fruits = example.PublicList;

        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}


// Word example = new Word();
// List<string> words = example.wordList;

// foreach (var word in words)
// {
//     Console.WriteLine(word);
// }