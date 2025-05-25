using System;
using System.Net;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string prompt, string response)
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = prompt;
        _entryText = response;
    }

}