using System;
using JetBrains.Annotations;
using static System.Console;




namespace Highlighters
{
    public class Squiggles
    {
        public int field; 
        /*suggestion*/

            
        public void

        public void Test_Renamed(string s, bool optional = false)
        {
            test;
            /*warning*/ new Squiggles(11111111/*error*/);
            // respeller
            // shamsutdinova
            string memberInList = "";
            /*hint*/ field = 1;

            return;
        }
    }

    // several squiggles on one member
    class person
    {
        [NotNull]
        public string Name { get; set; }// incorrect formatting
        [NotNull]
        public string PlaceOfBirth { get; set; }

        // Warning: Member with '[NotNull]' attribute is not initialized
        public person([NotNull] string name, string placeOfBirth)
        {
            Name = name;
            Console.WriteLine(@"Name: {0}, Place of birth: {1}",
                name, placeOfBirth);
        }
    }
}