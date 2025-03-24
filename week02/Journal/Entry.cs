using System;
using System.Collections.Generic;
using System.IO;

// Entry.cs
public class Entry
{

    // store the prompt that is displayed to for the user
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    // initialize properties when new entry is created
    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    // format the string representation
    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}