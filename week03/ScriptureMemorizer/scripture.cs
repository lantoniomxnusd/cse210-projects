using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int tries = 0;
        int maxTries = _words.Count * 3;

        while (numberToHide > 0 && tries < maxTries)
        {
            int index = rand.Next(_words.Count);
            if (!_words[index].isHidden())
            {
                _words[index].Hide();
                numberToHide--;
            }

            tries++;
        }
    }

    public string GetDisplayText()
    {
        List<string> displayedWords = new List<string>();
        foreach (var word in _words)
        {
            displayedWords.Add(word.GetDisplayText());
        }

        return $"{_reference.GetDisplayText()}{string.Join(" ", displayedWords)}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.isHidden())
                return false;
        }
        return true;
    }

}