using System;
using System.Xml.Serialization;

public class Verse
{
    public string Reference;
    public string Text;
    private List<Word> _words = new List<Word>();

    public Verse(string reference, string text)
    {
        Reference = reference;
        Text = text;
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.WriteLine($"{Reference}: {string.Join(" ", _words.ConvertAll(w => w.DisplayWord))}");
    }

    public void HideWords()
    {
        Random rand = new Random();
        foreach (Word word in _words)
        {
            if (rand.Next(2) == 0)  // Randomly hide 50% of words
            {
                word.HideWord();
            }
        }
    }
}
