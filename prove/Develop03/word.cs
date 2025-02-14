using System;
using System.Collections.Generic;

public class Word
{
    private string _theWord;
    private bool _hidden = false;

    public Word(string word)
    {
        _theWord = word;
    }

    public string DisplayWord
    {
        get
        {
            return _hidden ? new string('_', _theWord.Length) : _theWord;
        }
    }

    public void HideWord()
    {
        _hidden = true;
    }

    public void ShowWord()
    {
        _hidden = false;
    }
}