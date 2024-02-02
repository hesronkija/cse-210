using System;
using static System.Console;

class Journal
{
    List<Entry> entries = new List<Entry>();


    public void AddEntry(string prompt, string response, string date)
    {
        Entry entry = new Entry();
        entry.prompt = prompt;
        entry.response = response;
        entry.date = date;

        entries.Add(entry);
    }

    public void Display()
    {
        foreach(var entry in entries) {
            WriteLine($"{entry.date}: {entry.prompt}\n{entry.response}");
        }
    }
}