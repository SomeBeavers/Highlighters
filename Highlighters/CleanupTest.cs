#nullable enable
using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Highlighters
{
    public class CleanupTest<T> where T : new()
    {
        public CleanupTest(string s)
        {
            foreach (var memberInList in new List<T>())
                if (memberInList != null)
                    Console.WriteLine(memberInList);
                else
                    Console.WriteLine($"{nameof(memberInList)} is null");

            S = s;
        }

        public string S { get; set; }


        private void Test()
        {
            S = "";
        }

        private void Test([NotNull] string s)
        {
            if (s == null) throw new ArgumentNullException(nameof(s));
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}