using System;

namespace Highlighters
{
    public interface IFormattedString:IDisposable
    {
        /// <summary>
        /// xml doc comment
        /// <code>
        ///Console.WriteLine("Test");
        /// </code>
        // ReSharper disable once InvalidXmlDocComment
        /// <paramref name="dateTime1"/>
        /// </summary>
        /// <param name="dateTime"></param>
        public void FormattedString1(DateTime dateTime)
        {
            var comment = "comment \n";
            string formatted1 = string.Format("{0:hh:mm:ss t z} {1} {2}", dateTime, comment);
            string formatted2 = $@"{dateTime:hh:mm:ss t z} \n {comment} {unresolved}";

            Console.WriteLine(unresolved);
        }

        void ImplementMe();
    }
}