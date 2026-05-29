using System;
using System.Collections.Generic;


public class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private List<Comment> _comments = new List<Comment>();


    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
    }

    public void AddComment(Comment comment)
    {
        if (comment != null)
        {
            _comments.Add(comment);
        }
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return new List<Comment>(_comments);
    }

    public void Display()
    {
        Console.WriteLine($"Title: {this._title}");
        Console.WriteLine($"Author: {this._author}");
        Console.WriteLine($"Length: {this._lengthSeconds} seconds");
        Console.WriteLine($"Comments ({GetCommentCount()}):");
        foreach (var comments in _comments)
        {
            comments.Display();
        }
    }


}

