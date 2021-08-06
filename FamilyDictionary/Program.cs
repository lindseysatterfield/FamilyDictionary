using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Julie" }, { "age", "48" } });
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Regina" }, { "age", "68" } });
            myFamily.Add("father", new Dictionary<string, string>() { { "name", "Larry" }, { "age", "70" } });
            myFamily.Add("aunt", new Dictionary<string, string>() { { "name", "Rhonda" }, { "age", "59" } });
            myFamily.Add("dog son", new Dictionary<string, string>() { { "name", "Murphy" }, { "age", "14" } });

            foreach (var (family, dictionary) in myFamily)
            {
                var name = dictionary["name"];
                var age = dictionary["age"];

                Console.WriteLine($"{name} is my {family} and is {age} years old.");
            }
        }
    }
}
