using System;
using System.Globalization;

namespace Highlighters_Multi
{
    public class Preprocessor
    {
        private string comment;
#if NET5_0
        public void Preprocessor1()
        {
            Console.WriteLine(comment);
        }
#else
        public void Preprocessor2()
        {
            string test = Regex().ToString();
            Console.WriteLine(String.Format("{0} test {2} \n", test, CultureInfo.InvariantCulture));
        }

        private static int Regex()
        {
            return 1;
        }
#endif
    }
}