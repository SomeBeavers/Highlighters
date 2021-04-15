using System;

string jane = "Jane";
const string Surname = "Doe";
string? test = @$"{jane} {Surname}";
Console.WriteLine(test);

static void Test()
{
}

static void Test2()
{
    Test();
}