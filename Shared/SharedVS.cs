using System;
using Highlighters_Framework;

namespace Shared
{
    class SharedVS
    {
        private void Test()
        {
            new UseInShared().UseInSharedMethod();
            new UseInShared().UseInSharedMethod();
            new UseInShared().UseInSharedMethod();
            throw new NotImplementedException();
        }
    }
}

