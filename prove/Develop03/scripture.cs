using System;
using System.Xml.Serialization;

// Scripture class to hold multiple verses
public class Scripture
{
    private List<Verse> _verses = new List<Verse>();

    public void AddVerse(Verse verse)
    {
        _verses.Add(verse);
    }

    public void Display()
    {
        foreach (var verse in _verses)
        {
            verse.Display();
        }
    }

    public void HideWords()
    {
        foreach (var verse in _verses)
        {
            verse.HideWords();
        }
    }
}

