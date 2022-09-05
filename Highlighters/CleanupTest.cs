#nullable enable
using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Highlighters;

public class CleanupTest<T> where T : new()
{
    public CleanupTest(string s)
    {
        foreach (int memberInLisst in new List<T>())
            if (memberInLisst != null)
                Console.WriteLine(memberInLisst);
            else
                Console.WriteLine($"{nameof(memberInLisst)} is null");

        S = s;
    }

    public string S { get; set; }


    private void Test()
    {
        S = "";
    }

    private void Test2()
    {
        Test("", 1);
    }

    private void Test([NotNull] string memberInLisst = "", int t)
    {
        if (memberInLisst == null) throw new ArgumentNullException(nameof(memberInLisst));
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

    public void LetsDoSomeMoreTesting()
    {
        // TODO: comment is here 
        // TODO: and probably here should be a comment too
    }
}