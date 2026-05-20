class Reference
{
    private string _book {get; set;}
    private int _chapter {get; set;}
    private int _verse {get; set;} 
    private int _endVerse {get; set;}

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse; 
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public Reference(string reference)
    {
        
        string[] parts = reference.Split(' ');
        _book = parts[0];
        string[] chapterAndVerses = parts[1].Split(':');
        _chapter = int.Parse(chapterAndVerses[0]);
        string[] verses = chapterAndVerses[1].Split('-');
        _verse = int.Parse(verses[0]);
        _endVerse = verses.Length > 1 ? int.Parse(verses[1]) : _verse;
    }

    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}