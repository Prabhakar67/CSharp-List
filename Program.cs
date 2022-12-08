using System;
using System.Collections.Generic;

public class Example
{
    public static void Main(string[] args)
    {
        // Create a list of strings  
        var countries = new List<string>();
        countries.Add("India");
        countries.Add("Australia");
        countries.Add("Japan");
        countries.Add("Canada");
        countries.Add("Mexico");

        // Iterate list element using foreach loop  
        foreach (var country in countries)
        {
            Console.WriteLine(country);
        }
    }
}