using System;
using JetBrains.Annotations;
using static System.Console;
// ReSharper disable All



namespace Highlighters
{
    public class Squiggles
    {
        public int field; 
        /*suggestion*/

            
        
        public void Test(string s, bool optional = false)
        {
            test;
            /*warning*/ new Squiggles(11111111/*error*/);
            // shamsutdinova
            string memberInList = "";
            /*hint*/ field = 1;

            return;
        }
    }

    class Person
    {
        [NotNull]
        public string Name { get; set; }
        [NotNull]
        public string PlaceOfBirth { get; set; }

        // Warning: Member with '[NotNull]' attribute is not initialized
        public Person([NotNull] string name, string placeOfBirth)
        {
            Name = name;
            Console.WriteLine(@"Name: {0}, Place of birth: {1}",
                name, placeOfBirth);
        }
    }
}