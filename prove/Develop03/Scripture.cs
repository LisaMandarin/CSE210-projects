using System;
public class Scripture
{
    private List<Word> words = new List<Word>();
    private Random random = new Random();
    private Reference reference;
   
    public Scripture(Reference reference, string scriptureWords)
    {
            this.reference = reference;
            string[] wordArray = scriptureWords.Split(' ');
            foreach (string singleWord in wordArray)
            {
                Word word = new Word(singleWord);
                words.Add(word);
            }
    }
    public void HideWords()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden)
            {
                if (random.Next(1,4) == 1)
                {
                    word.Hide();
                }
            }
        }
    }
    public string GetRenderedText()
    {
        string renderedText = reference.GenerateReference() + " ";
        foreach (Word word in words)
        {
            renderedText += word.GetRenderedText() + " ";
        }
        return renderedText;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden)
                return false;
        }
        return true;
    }
}