
using System.Collections.Concurrent;

class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    Random _random = new Random();


    // methods
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        foreach (string w in text.Split(" "))
        {
            Word word = new Word(w);
            _words.Add(word);

        }
    }

    // public string GetReference()
    // {
    //     return _reference.DisplayReference();
    // }

    // public List<Word> GetWords()
    // {
    //     return _words;
    // }

    public void DisplayScripture()
    {
        string text = "";
        foreach (Word word in _words)
        {
            text += word.GetWord() + " ";
        }

        Console.WriteLine($"{_reference.DisplayReference()} {text}");
    }

    public void HideRandomWords()
    {
        for (int j = 0; j < 3; j++)
        {
            int i = _random.Next(_words.Count);

            Word randomWord = _words[i];
            if (!randomWord.GetIsHidden())
            {
                randomWord.HideWord();
            }
        }

    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.GetIsHidden())
            {
                return false;
            }
        }

        return true;
    }



}