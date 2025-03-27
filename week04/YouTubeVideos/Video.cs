using System;
using System.Collections.Generic;

public class Video
{
    // Attributes
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments;

    // Constructor
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    // Methods
    public string Title
    {
        get { return _title; }
    }

    public string Author
    {
        get { return _author; }
    }

    public double Length
    {
        get { return _length; }
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayComments()
    {
        foreach (var comment in _comments)
        {
            Console.WriteLine($"Comment by {comment.Name}: {comment.Text}");
        }
    }
}
