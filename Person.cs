using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string FirstName { get; set; }

    public Person(string name, int id)
    {
        Name = name;
        Id = id;

    }

    public override string ToString()
    {
        return $"Name: {Name}" + $"Id: {Id}";

    }
}