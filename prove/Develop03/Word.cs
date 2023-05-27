using System;

public class Word
{    
    private string text;
    public bool IsHidden;
    public Word(string text)
    {
        this.text = text;
        IsHidden = false;   
    }
    public void Hide()
    {
        IsHidden = true;
    }

    public string GetRenderedText()
    {
        if (IsHidden)
        {
            return "_____";
        }
        return text;
    }
    
}