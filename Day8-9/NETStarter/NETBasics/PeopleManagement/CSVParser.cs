using System;
using System.Collections.Generic;
using System.IO;
public class CSVParser
{
    public List<Person> People { get; set; }

    public CSVParser()
    {
        People = new List<Person>();
    }

    public void Parse(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine())!= null)
            {
                var values = line.Split(',');
                var person = new Person
                {
                    Index = values[0],
                    FirstName = values[2],
                    LastName = values[3]
                };
                People.Add(person);
            }
        }
    }

    public void PrintNames()
    {
        foreach (var person in People)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }
    }
}