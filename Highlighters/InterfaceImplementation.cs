using System;

namespace Highlighters
{
    class InterfaceImplementation : IFormattedString
    {
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