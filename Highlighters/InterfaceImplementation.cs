using System;

namespace Highlighters
{
    class InterfaceImplementation : IFormattedString
    {
        protected int T = 1;
        public void Test()
        {
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void ImplementMe()
        {
            throw new NotImplementedException();
        }
    }
}