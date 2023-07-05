using System;
using System.Collections.Generic;


public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLength()
    {
        return _length;
    }
    public void StoreComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int CountComment()
    {
        return _comments.Count;
    }
    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            string name = comment.GetCommentName();
            string text = comment.GetCommentText();
            Console.WriteLine($"{name} - {text}");
        }
    }
    public void DisplayData()
    {
        string title = GetTitle();
        string author = GetAuthor();
        int length = GetLength();
        int commentNumber = CountComment();
        Console.WriteLine($"{title} by {author} ({length} seconds)");
        Console.WriteLine($"There are {commentNumber} comments");
        DisplayComments();
        Console.WriteLine("==========================================");
    }
    
}