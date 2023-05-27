using System;

public class Reference
{
    private string book;
    private int chapter;
    private int verse1;
    private int verse2;
    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse1 = verse;
        this.verse2 = -1;
    }
    public Reference(string book, int chapter, int verse1, int verse2)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse1 = verse1;
        this.verse2 = verse2;
    }
    public string GenerateReference()
    {
        string reference = $"{book} {chapter}: ";
        if (verse2 == -1)
        {
            return reference += verse1;
        }
        else
        {
            return reference += $"{verse1} - {verse2}";
        }
        
    }
    
}