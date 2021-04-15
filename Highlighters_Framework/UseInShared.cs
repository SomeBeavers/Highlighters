namespace Highlighters_Framework
{
    public class UseInShared
    {
        public void UseInSharedMethod()
        {
            void NewFunction()
            {
            }

            NewFunction();
        }
    }
}