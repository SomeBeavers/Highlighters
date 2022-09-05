using System;

namespace Highlighters
{
    public class Class1Base
    {
        public string Name11 { get; private set; }
    }

    public class Class1 : Class1Base
    {
        public Class1(string name1)
        {
            NewMethod_renamed(name1);
        }

        // comment

        private void NewMethod_renamed(string name1)
        {
            string nameRenamed = $@"{DateTime.Now:1} {name1}";
            
            
            Name11 = nameRenamed;
        }







        private bool Test()
        {
            return true;
        }
    }
}