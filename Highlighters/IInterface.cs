using JetBrains.Annotations;

namespace Highlighters
{
    interface IInterface
    {
        [UsedImplicitly]
        string ImplementedInterfaceMethod(string name) => name;

        [UsedImplicitly]
        public string ImplementedInterfaceMethod(string name, bool b) => name;

        [UsedImplicitly]
        public int NotImplementedMethod();

        [UsedImplicitly]
        void Method2();
    }
}