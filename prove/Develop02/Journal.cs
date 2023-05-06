using System;

public class Journal
{
    public List<Entry> _entires = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entires.Add(entry);
    }
    public void Display()
    {
        foreach (Entry entry in _entires)
        {
            entry.Display();
        }
    }

}