using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Reference { get; set; }
    public List<Word> Words { get; set; }

    // Constructor
    public Scripture(string referenceText, string scriptureText)
    {
        Reference = new Reference(referenceText);
        Words = scriptureText.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine(Reference.ReferenceText);
        foreach (var word in Words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();
        if (visibleWords.Count > 0)
        {
            var random = new Random();
            var wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.IsHidden = true;
        }
    }

    public bool IsComplete()
    {
        return Words.All(w => w.IsHidden);
    }
}
