using System;


public class Comment
{
    private string _commenterName { get; set; }
    private string _text { get; set; }

    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    public void Display()
    {
        Console.WriteLine($"{_commenterName}: {_text}");
    }
}

